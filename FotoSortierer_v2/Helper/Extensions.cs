using System;

namespace FotoSortierer_v2.Helper
{
    public static class Extensions
    {
        /// <summary>
        /// Gets the offset to local timezone in hours.
        /// </summary>
        /// <param name="timeZoneInfo">The time zone information.</param>
        /// <returns>Returns the offset in hours.</returns>
        public static int GetOffsetInHours(this TimeZoneInfo timeZoneInfo)
        {
            var offset = (timeZoneInfo.BaseUtcOffset - TimeZoneInfo.Local.BaseUtcOffset).Hours;
            return offset;
        }
    }
}