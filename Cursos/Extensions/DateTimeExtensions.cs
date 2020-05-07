using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace System {
   static class DateTimeExtensions {

        public static string ElapedTime(this DateTime thisObj) {

            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0) {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + " Horas";
            }
            else {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " Dias";
            }
        }
    }
}
