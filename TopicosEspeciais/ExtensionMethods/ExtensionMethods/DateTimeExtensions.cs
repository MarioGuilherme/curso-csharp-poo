using System.Globalization;

namespace System {
    public static class DateTimeExtensions {  // |-- Extendendo o objeto DateTime
        public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24)
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";

            return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
        }
    }
}