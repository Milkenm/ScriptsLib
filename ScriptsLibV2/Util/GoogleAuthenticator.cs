using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Util
{
    // https://stackoverflow.com/questions/6421950/is-there-a-tutorial-on-how-to-implement-google-authenticator-in-net-apps
    public class GoogleAuthenticator
    {
        private const int IntervalLength = 30;
        private const int PinLength = 6;
        private static readonly int PinModulo = (int)Math.Pow(10, PinLength);
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        ///   Number of intervals that have elapsed.
        /// </summary>
        public static long CurrentInterval
        {
            get
            {
                long elapsedSeconds = (long)Math.Floor((DateTime.UtcNow - UnixEpoch).TotalSeconds);
                return elapsedSeconds / IntervalLength;
            }
        }

        public static Image GenerateQRCode(string username, string product, byte[] key, int size)
        {
            string keyString = key.ToBase32();

            string otpUrl = $"otpauth://totp/{username}?secret={keyString}&issuer={product}".EncodeToUrl();
            string qrCodeUrl = $"https://chart.apis.google.com/chart?cht=qr&chs={size}x{size}&chl={otpUrl}";

            using (WebClient Client = new WebClient())
            {
                byte[] qrBytes = Client.DownloadData(qrCodeUrl);
                using (MemoryStream ms = new MemoryStream(qrBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        public static Image GenerateQRCode(string username, string product, string key, int size)
        {
            return GenerateQRCode(username, product, key.ToBytes(), size);
        }

        public static int GeneratePIN(byte[] key, long interval)
        {
            const int sizeOfInt32 = 4;

            byte[] counterBytes = BitConverter.GetBytes(interval);

            if (BitConverter.IsLittleEndian)
            {
                //spec requires bytes in big-endian order
                Array.Reverse(counterBytes);
            }

            byte[] hash = new HMACSHA1(key).ComputeHash(counterBytes);
            int offset = hash[hash.Length - 1] & 0xF;

            byte[] selectedBytes = new byte[sizeOfInt32];
            Buffer.BlockCopy(hash, offset, selectedBytes, 0, sizeOfInt32);

            if (BitConverter.IsLittleEndian)
            {
                //spec interprets bytes in big-endian order
                Array.Reverse(selectedBytes);
            }

            int selectedInteger = BitConverter.ToInt32(selectedBytes, 0);

            //remove the most significant bit for interoperability per spec
            int truncatedHash = selectedInteger & 0x7FFFFFFF;

            //generate number of digits for given pin length
            int pin = truncatedHash % PinModulo;

            return Convert.ToInt32(pin.ToString(CultureInfo.InvariantCulture).PadLeft(PinLength, '0'));
        }

        public static int GeneratePIN(string key, long interval)
        {
            return GeneratePIN(key.ToBytes(), interval);
        }

        public static int GeneratePIN(string key)
        {
            return GeneratePIN(key, CurrentInterval);
        }
    }
}
