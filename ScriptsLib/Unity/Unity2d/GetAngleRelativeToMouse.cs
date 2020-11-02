using UnityEngine;

namespace ScriptsLib.Unity
{
	public static partial class Unity2d
	{
		public static float GetAngleRelativeToObject(Vector2 v1, Vector2 v2)
		{
			float rads = Mathf.Atan2(v1.y - v2.y, v1.x - v2.x);
			return 180 / Mathf.PI * rads;
		}
	}
}