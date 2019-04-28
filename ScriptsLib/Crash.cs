#region Usings
using System.ComponentModel;
using System.Threading.Tasks;
#endregion Usings



namespace ScriptsLib.Crash
{

	public partial class Crash
	{
		private int _Variable { get; set; }
		
		public async Task StackOverflow()
		{
			_Variable++;
			await StackOverflow();
		}
	}
}
