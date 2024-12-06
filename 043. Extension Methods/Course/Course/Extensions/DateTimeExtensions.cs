using System;
using System.Globalization;

namespace System //Pelo fato do Datetime ser do namespace System, podemos colocar aqui tbm. 
{
    static internal class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) // O método precisa ser static e é necessário o this. 
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }

        }


    }
}
