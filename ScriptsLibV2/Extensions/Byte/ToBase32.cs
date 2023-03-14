using System.Text;

namespace ScriptsLibV2.Extensions
{
	public static partial class ByteExtensions
	{
		// https://stackoverflow.com/questions/6421950/is-there-a-tutorial-on-how-to-implement-google-authenticator-in-net-apps
		public static string ToBase32(this byte[] data)
		{
			const int inByteSize = 8;
			const int outByteSize = 5;
			const string base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

			int i = 0, index = 0;
			StringBuilder sb = new StringBuilder((data.Length + 7) * inByteSize / outByteSize);

			while (i < data.Length)
			{
				int currentByte = data[i];
				int digit;

				//Is the current digit going to span a byte boundary?
				if (index > (inByteSize - outByteSize))
				{
					int nextByte;

					if ((i + 1) < data.Length)
					{
						nextByte = data[i + 1];
					}
					else
					{
						nextByte = 0;
					}

					digit = currentByte & (0xFF >> index);
					index = (index + outByteSize) % inByteSize;
					digit <<= index;
					digit |= nextByte >> (inByteSize - index);
					i++;
				}
				else
				{
					digit = (currentByte >> (inByteSize - (index + outByteSize))) & 0x1F;
					index = (index + outByteSize) % inByteSize;

					if (index == 0)
					{
						i++;
					}
				}

				sb.Append(base32Alphabet[digit]);
			}

			return sb.ToString();
		}
	}
}
