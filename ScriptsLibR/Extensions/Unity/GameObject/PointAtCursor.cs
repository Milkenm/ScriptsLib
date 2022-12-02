using ScriptsLibR.Utils;

using UnityEngine;

namespace ScriptsLibR.Extensions
{
	public static class UnityGameObjectExtensions
	{
		public static void PointAtCursor(this GameObject gameObject)
		{
			gameObject.transform.rotation = Quaternion.Euler(0, 0, UnityUtils.GetAngleRelativeToObject(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));
		}
	}
}