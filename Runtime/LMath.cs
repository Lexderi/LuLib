using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LuLib.Math
{
    public static class LMath
    {
        public static float RoundToNearestStep(float value, float step)
        {
            return Mathf.Round(value / step) * step;
        }
        public static float Map(float value, float start1, float stop1, float start2, float stop2, bool clamp = false)
        {
            float range1 = stop1 - start1;
            float range2 = stop2 - start2;

            float newValue = range2 / range1 * (value - start1) + start2;

            if (clamp)
            {
                newValue = Mathf.Clamp(newValue, start2, stop2);
            }
            return newValue;
        }
    }
}
