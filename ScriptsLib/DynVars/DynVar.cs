using ScriptsLib.Extensions;

using System;
using System.IO;
using System.Threading.Tasks;

namespace ScriptsLib
{
	public class DynVars
	{
		/// <summary>Stores variables in separate files, where the file name is the variable name and the file content is the variable's value</summary>
		/// <param name="folderPath">The forlder where the variable files will be stored.</param>
		public DynVars(string folderPath)
		{
			DynVarsFolderPath = folderPath;

			if (!Directory.Exists(DynVarsFolderPath))
			{
				Directory.CreateDirectory(DynVarsFolderPath);
			}
		}

		private string _DynVarsFolderPath;

		/// <summary>The location of the file where the variables will be stored.</summary>
		public string DynVarsFolderPath
		{
			get { return _DynVarsFolderPath; }
			set
			{
				if (!value.EndsWith(@"\") || !value.EndsWith("/"))
				{
					value += @"\";
				}

				_DynVarsFolderPath = value;
			}
		}

		public async Task SetVariable(string name, object value)
		{
			if (!string.IsNullOrEmpty(name) && value != null)
			{
				string filePath = DynVarsFolderPath + name;

				File.Delete(filePath);
				using (FileStream fs = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
				{
					byte[] varBytes = value.ToByteArray();
					await fs.WriteAsync(varBytes, 0, varBytes.Length).ConfigureAwait(false);
				}
			}
			else
			{
				if (string.IsNullOrEmpty(name))
				{
					throw new Exception("Variable name is empty.");
				}
				else
				{
					throw new Exception("Variable value is null.");
				}
			}
		}

		public T ReadVariable<T>(string name)
		{
			if (!string.IsNullOrEmpty(name) || !File.Exists(DynVarsFolderPath + name))
			{
				byte[] bytes = File.ReadAllBytes(DynVarsFolderPath + name);
				return (T)bytes.ToObject();
			}
			else
			{
				if (string.IsNullOrEmpty(name))
				{
					throw new Exception("Variable name is empty.");
				}
				else
				{
					throw new Exception("Variable does not exist.");
				}
			}
		}
	}
}