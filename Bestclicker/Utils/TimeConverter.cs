using System;

namespace AutoClicker.Utils
{
    internal static class TimeConverter
    {
        public static int ToMilliseconds(decimal value, string unit)
        {
            return unit switch
            {
                "ms" => (int)value,
                "sec" => (int)(value * 1000),
                "min" => (int)(value * 60000),
                "ore" => (int)(value * 3600000),
                _ => (int)value
            };
        }
    }
}