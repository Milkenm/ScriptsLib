#region Usings
using UnityEngine;
#endregion Usings



namespace ScriptsLib.Unity
{
	public class Unity2D
	{
		#region GetAngleRelativeToObject
		public float GetAngleRelativeToObject(Vector2 _Vector1, Vector2 _Vector2)
		{
			float _AngleRad = Mathf.Atan2(_Vector1.y - _Vector2.y, _Vector1.x - _Vector2.x);
			return 180 / Mathf.PI * _AngleRad;
		}
		#endregion GetAngleRelativeToObject



		#region PointAtMouse
		public void PointAtMouse(GameObject _Object)
		{
			_Object.transform.rotation = Quaternion.Euler(0, 0, GetAngleRelativeToObject(_Object.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));
		}
		#endregion PointAtMouse
	}
}
