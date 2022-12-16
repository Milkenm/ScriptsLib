using ScriptsLibV2.Util;

using UnityEngine;

namespace ScriptsLibV2.Extensions
{
	public static class UnityGameObjectExtensions
	{
		public static void PointAtCursor(this GameObject gameObject)
		{
			gameObject.transform.rotation = Quaternion.Euler(0, 0, UnityUtils.GetAngleRelativeToObject(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));
		}
	}
}