using UnityEngine;

namespace Utility
{
    public static class PhysicsUtil
    {
        public static Vector3[] CreateRaycastCircleXZ(Vector3 origin, float radius, int amount)
        {
            var raycasts = new Vector3[amount];
            raycasts[0] = origin;
            var step = 360f / amount;
            for (var i = 1; i < amount; i++) {
                var angle = step * i;
                var pos = origin;
                pos.x += Mathf.Cos(angle) * radius;
                pos.z += Mathf.Sin(angle) * radius;
                raycasts[i] = pos;
            }

            return raycasts;
        }

        public static void CreateRaycastCircleXZNonAlloc(ref Vector3[] raycasts, Vector3 origin, float radius,
            int amount)
        {
            raycasts[0] = origin;
            var step = 360f / amount;
            for (var i = 1; i < amount; i++) {
                var angle = step * i;
                var pos = origin;
                pos.x += Mathf.Cos(angle) * radius;
                pos.z += Mathf.Sin(angle) * radius;
                raycasts[i] = pos;
            }
        }

        public static Vector3[] CreateRaycastCircleXY(Vector3 origin, float radius, int amount)
        {
            var raycasts = new Vector3[amount];
            raycasts[0] = origin;
            var step = 360f / amount;
            for (var i = 1; i < amount; i++) {
                var angle = step * i;
                var pos = origin;
                pos.x += Mathf.Cos(angle) * radius;
                pos.y += Mathf.Sin(angle) * radius;
                raycasts[i] = pos;
            }

            return raycasts;
        }

        public static void CreateRaycastCircleXYNonAlloc(ref Vector3[] raycasts, Vector3 origin, float radius,
            int amount)
        {
            raycasts[0] = origin;
            var step = 360f / amount;
            for (var i = 1; i < amount; i++) {
                var angle = step * i;
                var pos = origin;
                pos.x += Mathf.Cos(angle) * radius;
                pos.y += Mathf.Sin(angle) * radius;
                raycasts[i] = pos;
            }
        }
    }
}