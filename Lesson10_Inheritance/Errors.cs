using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    public static class Errors
    {
        static int lastErrorCode = 0;
        public static int LastErrorCode { get => lastErrorCode; set => lastErrorCode = value; }

        static string[] errorsDescription = {
            "",
            "Недопустимая дата рождения",
            "Недопустимая дата поступления",
            "Недопустимый возраст студента",
        };

        public static string GetCurrentErrorInfo(int errorCode)
        {
            return errorsDescription[errorCode];
        }

        public static DateTime ErrorDateTime(int errorCode)
        {
            lastErrorCode = errorCode;
            return new DateTime();
        }
    }
}
