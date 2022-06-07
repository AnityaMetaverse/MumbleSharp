using System;
using System.Collections.Generic;
using System.Text;

namespace MumbleSharp.Audio
{
    class NoiseDetector
    {
        public static float MaxVolume = 0.9f;
        public static float MinVolume = -0.9f;

        public static bool IsNoise(byte[] buffer)
        {
            for (int index = 0; index < buffer.Length; index += 2)
            {
                float value = BitConverter.ToInt16(buffer, index);
                if (value < MinVolume && value > 0.9f)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
