using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Student : Person
    {
        uint yearIn;
        string specialtyCode;
        
        public Student(string fio, DateTime birthday, string address, string phone, uint yearIn, string specialtyCode) : base(fio, birthday, address, phone)
        {
            YearIn = yearIn;
            SpecialtyCode = specialtyCode;
            Birthday = birthday;
        }

        public new DateTime Birthday { get => Birthday;
            set => base.Birthday = (uint)(DateTime.Now.Year - value.Year) > Constants.MaxStudentAge ? new DateTime(1, 1, 1) : value; }

        // Добавить проверку, чтобы год поступления был как минимум на 10 лет больше года рождения
        public uint YearIn { get => yearIn; set => yearIn = ((uint)DateTime.Now.Year - Constants.MaxYearDistance) > Constants.MaxYearDistance ? (uint)DateTime.Now.Year - Constants.MaxYearDistance : value; } 

        public string SpecialtyCode { get => specialtyCode; set => specialtyCode = value; }

        public DateTime PassportDate { get => passportDate; set => passportDate = value; }

        public override string ToString()
        {
            //            return Errors.LastErrorCode > 0 ? Errors.GetCurrentErrorInfo() : "Student " + base.ToString() + ". YearIn: " + YearIn + ", specialty: " + SpecialtyCode ;

            if (this.ErrorCode > 0)
                return Errors.GetCurrentErrorInfo(this.ErrorCode);
            else
                return "Student " + base.ToString() + 
                    ". YearIn: " + YearIn + 
                    ", specialty: " + SpecialtyCode;
        }
    }
}
