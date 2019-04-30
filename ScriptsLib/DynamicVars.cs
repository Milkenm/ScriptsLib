#region Usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using ScriptsLib.Database;
#endregion Usings



namespace ScriptsLib.DynnamicVars
{
	public class SlDynamicVars
	{
		public static string _DatabasePath { get; set; }


		SlDatabase _Database = new SlDatabase();





		public async Task DVar(string _Variable, string _Value)
		{
			#region ERROR CHECKING
			if (!File.Exists(_DatabasePath))
			{
				_Database.CreateDatabase(_DatabasePath).GetAwaiter();
			}
			if (String.IsNullOrEmpty(_Variable) || String.IsNullOrEmpty(_Value))
			{
				throw new Exception("Variable and/or Value string cannot be null or empty!");
			}
			#endregion ERROR CHECKING

			List<SlDatabase.TableFields> _Fields = new List<SlDatabase.TableFields>();
			SlDatabase.TableFields _Field = new SlDatabase.TableFields();


			_Field.Name = "ID";
			_Field.DataType = SlDatabase.SqlDataTypes.Text;
			_Fields.Add(_Field);

			_Field.Name = "Value";
			_Field.DataType = SlDatabase.SqlDataTypes.Text;
			_Fields.Add(_Field);



			string _TableName = "DynamicVars";
			await _Database.CreateTable(_TableName, _Fields);
		}
	}
}
