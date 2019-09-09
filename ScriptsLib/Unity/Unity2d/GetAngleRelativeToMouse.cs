#region Usings
using UnityEngine;
#endregion Usings



namespace ScriptsLib.nUnity
{
	public static partial class Unity2d
	{
		public static float GetAngleRelativeToObject(Vector2 _Vector1, Vector2 _Vector2)
		{
			float _AngleRad = Mathf.Atan2(_Vector1.y - _Vector2.y, _Vector1.x - _Vector2.x);
			return 180 / Mathf.PI * _AngleRad;
		}
	}
}
