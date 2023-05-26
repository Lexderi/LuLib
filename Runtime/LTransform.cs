using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LuLib.Transform
{
    public static class LTransform
    {
        #region Set Position
        /// <summary>
        /// sets the x component of the position
        /// </summary>
        /// <param name="t">transform</param>
        /// <param name="x">new x</param>
        public static void SetPosX(this UnityEngine.Transform t, float x)
        {
            Vector3 pos = t.position;
            pos.x = x;
            t.position = pos;
        }
        /// <summary>
        /// sets the y component of the position
        /// </summary>
        /// <param name="t">transform</param>
        /// <param name="y">new y</param>
        public static void SetPosY(this UnityEngine.Transform t, float y)
        {
            Vector3 pos = t.position;
            pos.y = y;
            t.position = pos;
        }
        /// <summary>
        /// sets the z component of the position
        /// </summary>
        /// <param name="t">transform</param>
        /// <param name="z">new z</param>
        public static void SetPosZ(this UnityEngine.Transform t, float z)
        {
            Vector3 pos = t.position;
            pos.z = z;
            t.position = pos;
        }
        #endregion // Set Position
    }
}
