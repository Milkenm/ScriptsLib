using System.Collections.Generic;
using System.Text;

namespace ScriptsLibV2
{
	public class StringConnector
	{
		private readonly List<string> StringsList = new List<string>();

		public void Append(string str)
		{
			StringsList.Add(str);
		}

		public void AddJoiner(string joiner)
		{
			for (int i = StringsList.Count - 1; i > 0; i--)
			{
				StringsList.Insert(i, joiner);
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			StringsList.ForEach(str => sb.Append(str));
			return sb.ToString();
		}
	}
}
