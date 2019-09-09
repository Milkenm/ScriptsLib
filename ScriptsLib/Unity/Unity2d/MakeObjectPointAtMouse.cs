#region Usings
using UnityEngine;
#endregion Usings



namespace ScriptsLib.nUnity
{
	public static partial class Unity2d
	{
		public static void MakeObjectPointAtMouse(GameObject _Object)
		{
			_Object.transform.rotation = Quaternion.Euler(0, 0, GetAngleRelativeToObject(_Object.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));
		}
	}
}
