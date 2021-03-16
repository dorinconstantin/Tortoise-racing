using System;

namespace Tortoise_racing
{
    public class Tortoise
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            var t = TimeSpan.FromHours((double)g / (v2 - v1));
            return new[] { t.Hours, t.Minutes, t.Seconds };
        }
    }
}