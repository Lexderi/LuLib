using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace LuLib.Vector
{
    public static class LVector
    {
        #region Vector2

        #region Rotate
        /// <summary>
        /// Rotates the vector
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="angle">angle in degrees</param>
        public static void Rotate(this ref Vector2 v, float angle)
        {
            // pre-calculate sin and cos
            float s = Mathf.Sin(angle * Mathf.Deg2Rad);
            float c = Mathf.Cos(angle * Mathf.Deg2Rad);

            // rotation matrix
            float x = v.x * c - v.y * s;
            float y = v.x * s + v.y * c;
            v.Set(x, y);
        }
        /// <param name="v">vector</param>
        /// <returns>rotation of vector relative to positive x-Axis</returns>
        public static float GetRotation(this Vector2 v) => Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg - 90;
        #endregion // Rotate

        #region Clamp
        /// <summary>
        /// clamps the magnitude between minimum and maximum value
        /// </summary>
        /// <param name="value">the value which gets clamped</param>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <returns>result</returns>
        public static Vector2 ClampMagnitude(Vector2 value, float min, float max)
        {
            float length = value.magnitude;

            if (length < min)
                value.SetMagnitude(min);

            else if (length > max)
                value.SetMagnitude(max);

            return value;
        }
        /// <summary>
        /// clamps the length between 0 and 1
        /// </summary>
        /// <param name="value">the value which gets clamped</param>
        /// <returns>result</returns>
        public static Vector2 ClampMagnitude01(Vector2 value) => ClampMagnitude(value, 0, 1);
        #endregion // Clamp

        #region Rounding
        /// <summary>
        /// Rounds x and y to the nearest integer
        /// </summary>
        /// <param name="value">vector that gets rounded</param>
        /// <returns>rounded vector</returns>
        public static Vector2 Round(Vector2 value)
        {
            value.Set(Mathf.Round(value.x), Mathf.Round(value.y));
            return value;
        }
        /// <summary>
        /// Sets x and y to the largest integer smaller or equal to the value
        /// </summary>
        /// <param name="value">vector that gets floored</param>
        /// <returns>floored vector</returns>
        public static Vector2 Floor(Vector2 value)
        {
            value.Set(Mathf.Floor(value.x), Mathf.Floor(value.y));
            return value;
        }
        /// <summary>
        /// Sets x and y to the smallest integer larger or equal to the value
        /// </summary>
        /// <param name="value">vector that gets ceiled</param>
        /// <returns>ceiled vector</returns>
        public static Vector2 Ceil(Vector2 value)
        {
            value.Set(Mathf.Ceil(value.x), Mathf.Ceil(value.y));
            return value;
        }
        #endregion // Rounding

        #region Magnitude
        /// <summary>
        /// Limits the magnitude of the vector to the maximum magnitude
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="maxLength">maximum magnitude</param>
        public static void Limit(this ref Vector2 v, float maxMag)
        {
            if (v.magnitude > maxMag) v.SetMagnitude(maxMag);
        }
        /// <summary>
        /// Sets the magnitude of the vector
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="magnitude"></param>
        public static void SetMagnitude(this ref Vector2 v, float magnitude) => v = (magnitude / v.magnitude) * v;
        #endregion // Magnitude

        #region Random
        /// <summary>
        /// Generates random vector2
        /// </summary>
        /// <returns>random vector with x and y between 0 and 1</returns>
        public static Vector2 RandomVector2() => new(Random.value, Random.value);

        /// <summary>
        /// Generates random vector2
        /// </summary>
        /// <param name="min">minimum possible vector (inclusive)</param>
        /// <param name="max">maximum possible vector (inclusive)</param>
        /// <returns>random vector between minimum vector and maximum vector</returns>
        public static Vector2 RandomVector2(Vector2 min, Vector2 max) =>
            new(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
        #endregion // Random

        #region Get

        public static Vector2 GetXX(this Vector2 v) => new (v.x, v.x);
        public static Vector2 GetYX(this Vector2 v) => new (v.y, v.x);
        public static Vector2 GetYY(this Vector2 v) => new (v.y, v.y);
            
        public static Vector3 GetXXX(this Vector2 v) => new (v.x, v.x, v.x);
        public static Vector3 GetXXY(this Vector2 v) => new (v.x, v.x, v.y);
        public static Vector3 GetXYX(this Vector2 v) => new (v.x, v.y, v.x);
        public static Vector3 GetXYY(this Vector2 v) => new (v.x, v.y, v.y);
        public static Vector3 GetX0X(this Vector2 v) => new (v.x, 0, v.x);
        public static Vector3 GetX0Y(this Vector2 v) => new (v.x, 0, v.y);
        public static Vector3 GetYXX(this Vector2 v) => new (v.y, v.x, v.x);
        public static Vector3 GetYXY(this Vector2 v) => new (v.y, v.x, v.y);
        public static Vector3 GetYYX(this Vector2 v) => new (v.y, v.y, v.x);
        public static Vector3 GetYYY(this Vector2 v) => new (v.y, v.y, v.y);
        public static Vector3 GetY0X(this Vector2 v) => new (v.y, 0, v.x);
        public static Vector3 GetY0Y(this Vector2 v) => new (v.y, 0, v.y);
        
        #endregion

        #endregion // Vector2

        #region Vector3

        #region Clamp
        /// <summary>
        /// clamps the magnitude between minimum and maximum value
        /// </summary>
        /// <param name="value">the value which gets clamped</param>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <returns>result</returns>
        public static Vector3 ClampMagnitude(Vector3 value, float min, float max)
        {
            float length = value.magnitude;

            if (length < min)
                value.SetMagnitude(min);

            else if (length > max)
                value.SetMagnitude(max);

            return value;
        }
        /// <summary>
        /// clamps the magnitude between 0 and 1
        /// </summary>
        /// <param name="value">the value which gets clamped</param>
        /// <returns>result</returns>
        public static Vector3 ClampMagnitude01(Vector3 value) => ClampMagnitude(value, 0, 1);
        #endregion // Clamp

        #region Rotate

        /// <summary>
        /// Rotates the vector in the order: z => x => y
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="x">rotation around the x-Axis in degrees</param>
        /// <param name="y">rotation around the y-Axis in degrees</param>
        /// <param name="z">rotation around the z-Axis in degrees</param>
        public static void Rotate(this ref Vector3 v, float x, float y, float z)
        {
            // init variables
            float s, c; // sin and cos
            Vector3 newV = v;

            // rotate by z
            if (z != 0)
            {
                // pre-calculate sin and cos
                s = Mathf.Sin(z * Mathf.Deg2Rad);
                c = Mathf.Cos(z * Mathf.Deg2Rad);

                // rotation matrix (https://en.wikipedia.org/wiki/Rotation_matrix#In_three_dimensions)
                // ReSharper disable InconsistentNaming
                newV.x = v.x * c - v.y * s;
                newV.y = v.x * s + v.y * c;
                // ReSharper restore InconsistentNaming

                // update values
                v.x = newV.x;
                v.y = newV.y;
            }
            // rotate by x
            if (x != 0)
            {
                // pre-calculate sin and cos
                s = Mathf.Sin(x * Mathf.Deg2Rad);
                c = Mathf.Cos(x * Mathf.Deg2Rad);

                // rotation matrix (https://en.wikipedia.org/wiki/Rotation_matrix#In_three_dimensions)
                // ReSharper disable InconsistentNaming
                newV.y = v.y * c - v.z * s;
                newV.z = v.y * s + v.z * c;
                // ReSharper restore InconsistentNaming

                // update values
                v.y = newV.y;
                v.z = newV.z;
            }
            // rotate by y
            if (y != 0)
            {
                // pre-calculate sin and cos
                s = Mathf.Sin(y * Mathf.Deg2Rad);
                c = Mathf.Cos(y * Mathf.Deg2Rad);

                // rotation matrix (https://en.wikipedia.org/wiki/Rotation_matrix#In_three_dimensions)
                // ReSharper disable InconsistentNaming
                newV.x = v.x * c + v.z * s;
                newV.z = v.x * -s + v.z * c;
                // ReSharper restore InconsistentNaming

                // update values
                v.x = newV.x;
                v.z = newV.z;
            }
        }
        /// <summary>
        /// Rotates the vector in the order: z => x => y
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="rotation">rotation in euler degrees</param>
        public static void Rotate(this ref Vector3 v, Vector3 rotation) 
        {
            v.Rotate(rotation.x, rotation.y, rotation.z);
        }
        #endregion // Rotate

        #region Rounding
        /// <summary>
        /// Rounds x, y and z to the nearest integer
        /// </summary>
        /// <param name="value">vector that gets rounded</param>
        /// <returns>rounded vector</returns>
        public static Vector3 Round(Vector3 value)
        {
            value.Set(Mathf.Round(value.x), Mathf.Round(value.y), Mathf.Round(value.z));
            return value;
        }
        /// <summary>
        /// Sets x, y and z to the largest integer smaller or equal to the value
        /// </summary>
        /// <param name="value">vector that gets floored</param>
        /// <returns>floored vector</returns>
        public static Vector3 Floor(Vector3 value)
        {
            value.Set(Mathf.Floor(value.x), Mathf.Floor(value.y), Mathf.Floor(value.z));
            return value;
        }
        /// <summary>
        /// Sets x, y and z to the smallest integer larger or equal to the value
        /// </summary>
        /// <param name="value">vector that gets ceiled</param>
        /// <returns>ceiled vector</returns>
        public static Vector3 Ceil(Vector3 value)
        {
            value.Set(Mathf.Ceil(value.x), Mathf.Ceil(value.y), Mathf.Ceil(value.z));
            return value;
        }
        #endregion // Rounding

        #region Magnitude
        /// <summary>
        /// Limits the magnitude of the vector to the maximum magnitude
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="maxLength">maximum magnitude</param>
        public static void Limit(this ref Vector3 v, float maxMag)
        {
            if (v.magnitude > maxMag) v.SetMagnitude(maxMag);
        }
        /// <summary>
        /// Sets the magnitude of the vector
        /// </summary>
        /// <param name="v">vector</param>
        /// <param name="magnitude"></param>
        public static void SetMagnitude(this ref Vector3 v, float magnitude) => v = (magnitude / v.magnitude) * v;
        #endregion // Magnitude

        #region Random
        /// <summary>
        /// Generates random vector3
        /// </summary>
        /// <returns>random vector with x, y and z between 0 and 1</returns>
        public static Vector3 RandomVector3() => new(Random.value, Random.value, Random.value);
        /// <summary>
        /// Generates random vector3
        /// </summary>
        /// <param name="min">minimum possible vector (inclusive)</param>
        /// <param name="max">maximum possible vector (inclusive)</param>
        /// <returns>random vector between minimum vector and maximum vector</returns>
        public static Vector3 RandomVector3(Vector3 min, Vector3 max) =>
            new(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
        #endregion //  Random

        #region Get
        public static Vector2 GetXX(this Vector3 v) => new (v.x, v.x);
        public static Vector2 GetXY(this Vector3 v) => new (v.x, v.y);
        public static Vector2 GetXZ(this Vector3 v) => new (v.x, v.z);
        public static Vector2 GetYX(this Vector3 v) => new (v.y, v.x);
        public static Vector2 GetYY(this Vector3 v) => new (v.y, v.y);
        public static Vector2 GetYZ(this Vector3 v) => new (v.y, v.z);
        public static Vector2 GetZX(this Vector3 v) => new (v.z, v.x);
        public static Vector2 GetZY(this Vector3 v) => new (v.z, v.y);
        public static Vector2 GetZZ(this Vector3 v) => new (v.z, v.z);
        
        public static Vector3 GetXXX(this Vector3 v) => new (v.x, v.x, v.x);
        public static Vector3 GetXXY(this Vector3 v) => new (v.x, v.x, v.y);
        public static Vector3 GetXXZ(this Vector3 v) => new (v.x, v.x, v.z);
        public static Vector3 GetXYX(this Vector3 v) => new (v.x, v.y, v.x);
        public static Vector3 GetXYY(this Vector3 v) => new (v.x, v.y, v.y);
        public static Vector3 GetXZX(this Vector3 v) => new (v.x, v.z, v.x);
        public static Vector3 GetXZY(this Vector3 v) => new (v.x, v.z, v.y);
        public static Vector3 GetXZZ(this Vector3 v) => new (v.x, v.z, v.z);
        public static Vector3 GetYXX(this Vector3 v) => new (v.y, v.x, v.x);
        public static Vector3 GetYXY(this Vector3 v) => new (v.y, v.x, v.y);
        public static Vector3 GetYXZ(this Vector3 v) => new (v.y, v.x, v.z);
        public static Vector3 GetYYX(this Vector3 v) => new (v.y, v.y, v.x);
        public static Vector3 GetYYY(this Vector3 v) => new (v.y, v.y, v.y);
        public static Vector3 GetYYZ(this Vector3 v) => new (v.y, v.y, v.z);
        public static Vector3 GetYZX(this Vector3 v) => new (v.y, v.z, v.x);
        public static Vector3 GetYZY(this Vector3 v) => new (v.y, v.z, v.y);
        public static Vector3 GetYZZ(this Vector3 v) => new (v.y, v.z, v.z);
        public static Vector3 GetZXX(this Vector3 v) => new (v.z, v.x, v.x);
        public static Vector3 GetZXY(this Vector3 v) => new (v.z, v.x, v.y);
        public static Vector3 GetZXZ(this Vector3 v) => new (v.z, v.x, v.z);
        public static Vector3 GetZYX(this Vector3 v) => new (v.z, v.y, v.x);
        public static Vector3 GetZYY(this Vector3 v) => new (v.z, v.y, v.y);
        public static Vector3 GetZYZ(this Vector3 v) => new (v.z, v.y, v.Z);
        public static Vector3 GetZZX(this Vector3 v) => new (v.z, v.z, v.x);
        public static Vector3 GetZZY(this Vector3 v) => new (v.z, v.z, v.y);
        public static Vector3 GetZZZ(this Vector3 v) => new (v.z, v.z, v.z);
        #endregion

        #endregion // Vector3
    }
}
