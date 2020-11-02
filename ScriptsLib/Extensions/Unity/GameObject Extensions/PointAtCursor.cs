using UnityEngine;

using static ScriptsLib.Unity.Unity2d;

namespace ScriptsLib.Extensions.Unity
{
	public static class GameObjectExtensions
	{
		public static void PointAtCursor(this GameObject obj)
		{
			obj.transform.rotation = Quaternion.Euler(0, 0, GetAngleRelativeToObject(obj.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));
		}
	}
}
