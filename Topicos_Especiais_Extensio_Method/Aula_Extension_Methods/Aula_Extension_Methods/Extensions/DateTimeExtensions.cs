using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Extension_Methods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); // recebendo o valor em TimeSpan da data de agora a data passar por parametro

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours"; // retorno em horas
            }else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days"; // retorno em dias
            }
        }
    }
}
