using System;

namespace Lesson10_Inheritance
{
    class Student : Person
    {
        uint yearIn;
        string specialtyCode;

        public Student(string fio, DateTime birthday, string address, string phone, uint yearIn, string specialtyCode) : base(fio, birthday, address, phone)
        {
            Birthday = birthday;
            YearIn = yearIn;
            SpecialtyCode = specialtyCode;
        }

        public new DateTime Birthday
        {
            get => Birthday;
            set => base.Birthday = (uint)(DateTime.Now.Year - value.Year) > Constants.MAX_STUDENT_AGE ? new DateTime(1, 1, 1) : value;
        }

        // Добавить проверку, чтобы год поступления был как минимум на 10 лет больше года рождения
        public uint YearIn { get => yearIn; set => yearIn = ((uint)DateTime.Now.Year - Constants.MIN_YEAR_DISTANCE) > Constants.MIN_YEAR_DISTANCE ? (uint)DateTime.Now.Year - Constants.MIN_YEAR_DISTANCE : value; } 


        public string SpecialtyCode { get => specialtyCode; set => specialtyCode = value.Trim(); }

        public DateTime PassportDate { get => passportDate; set => passportDate = value; }

        public override string ToString()
        {
            return (ErrorCode > 0) ? Errors.GetCurrentErrorInfo(ErrorCode) : "Student " + base.ToString() + ". YearIn: " + YearIn + ", specialty: " + SpecialtyCode;
        }
    }
}
