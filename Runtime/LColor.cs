using UnityEngine;

namespace LuLib.Color
{
    public static class LColor
    {
        public static Vector3 GetHSV(this UnityEngine.Color c)
        {
            UnityEngine.Color.RGBToHSV(c, out float h, out float s, out float v);

            return new(h, s, v);
        }

        public static UnityEngine.Color SetHSV(this UnityEngine.Color c, float h, float s, float v)
        {
            return c.SetHSV(new(h, s, v));
        }
        
        public static UnityEngine.Color SetHSV(this UnityEngine.Color c, Vector3 hsv)
        {
            c = UnityEngine.Color.HSVToRGB(hsv.x, hsv.y, hsv.z);

            return c;
        }
        
        public static UnityEngine.Color SetHue(this UnityEngine.Color c, float hue)
        {
            Vector3 hsv = c.GetHSV();

            hsv.x = hue;

            c = c.SetHSV(hsv);
            
            return c;
        }
        
        public static UnityEngine.Color SetSaturation(this UnityEngine.Color c, float saturation)
        {
            Vector3 hsv = c.GetHSV();

            hsv.y = saturation;

            c = c.SetHSV(hsv);
            
            return c;
        }
        
        public static UnityEngine.Color SetValue(this UnityEngine.Color c, float value)
        {
            Vector3 hsv = c.GetHSV();

            hsv.z = value;

            c = c.SetHSV(hsv);
            
            return c;
        }
    }
}