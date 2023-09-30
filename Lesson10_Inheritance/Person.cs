using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Person
    {
        private string fio;
        private DateTime birthday;
        private string address;
        private string phone;
        protected DateTime passportDate;
        private string email;
        private int errorCode = 0;

        public string Fio { get => fio; set => fio = value.Trim(); }
        public DateTime Birthday { get => birthday; set => birthday = (DateTime.Now.Year - value.Year) <= Constants.MAX_PERSON_AGE ? value : Errors.ErrorDateTime(1); }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime PassportDate { get => passportDate; set => passportDate = value; }  // TODO check not in future
        public int ErrorCode { get => errorCode; set => errorCode = value; }
        public string Email { get => email; set => email = value; }

        public Person()
        {
            Fio = "Anonymous";
            // ...
        }

        public Person(string fio, DateTime birthday, string address, string phone)
        {
            Fio = fio;
            Birthday = birthday;
            ErrorCode = Errors.LastErrorCode;
            Address = address;
            Phone = phone;
            // TODO  add default PassportDate Birthday + 14 years            
        }

        public override string ToString()
        {
            return ErrorCode > 0 ? Errors.GetCurrentErrorInfo(ErrorCode) : "Person: " + Fio + ", " + Birthday.ToShortDateString()
                + ". Address: " + Address + ", phone: " + Phone + "\tPassport: " + PassportDate.ToShortDateString() + "\te-mail: " + email;
        }
    }
}
