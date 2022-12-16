using UnityEngine;

namespace ScriptsLibV2.Util
{
    public static partial class UnityUtils
    {
        public static float GetAngleRelativeToObject(Vector2 firstObject, Vector2 secondObject)
        {
            float rads = Mathf.Atan2(firstObject.y - secondObject.y, firstObject.x - secondObject.x);
            return 180 / Mathf.PI * rads;
        }
    }
}