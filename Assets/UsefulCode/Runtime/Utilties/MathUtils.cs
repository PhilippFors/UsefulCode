using UnityEngine;

namespace Utility
{
    public static class MathUtils
    {
        public static float RLerp(float a, float b, float t)
        {
            t = 1f - Mathf.Pow(1f - t, Time.deltaTime * 60f);

            return (Mathf.Abs(a - b) > 0.001f) ? (a + (b - a) * t) : b;
        }

        public static Vector3 RLerp(Vector3 a, Vector3 b, float t)
        {
            t = 1f - Mathf.Pow(1f - t, Time.deltaTime * 60f);

            return (Vector3.Distance(a, b) > 0.001f) ? (a + (b - a) * t) : b;
        }

        public static float Remap(float input, Vector2 inMinMax, Vector2 outMinMax)
        {
            return outMinMax.x + (input - inMinMax.x) * (outMinMax.y - outMinMax.x) / (inMinMax.y - inMinMax.x);
        }
    }
}