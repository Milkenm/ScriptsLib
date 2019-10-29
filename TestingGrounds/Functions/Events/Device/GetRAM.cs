#region Usings
using static ScriptsLib.Device;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
    internal static partial class Events
    {
        internal static void GetRAM()
        {
            switch (MainForm.comboBox_device_getRam_ramType.Text)
            {
                case "Max":
                    MainForm.textBox_device_getRam_value.Text = ScriptsLib.Device.GetRAM(RAMType.Max).ToString(); break;
                case "Free":
                    MainForm.textBox_device_getRam_value.Text = ScriptsLib.Device.GetRAM(RAMType.Free).ToString(); break;
                case "Used":
                    MainForm.textBox_device_getRam_value.Text = ScriptsLib.Device.GetRAM(RAMType.Used).ToString(); break;
            }
        }
    }
}
