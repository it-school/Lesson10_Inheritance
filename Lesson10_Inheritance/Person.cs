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

        public string Fio { get => fio; set => fio = value; }
        public DateTime Birthday { get => birthday; set => birthday = ((DateTime.Now.Year - value.Year) <= Constants.MaxPersonAge ? value : Errors.ErrorDateTime(1)); }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime PassportDate { get => passportDate; set => passportDate = value; }  // TODO check not in future
        public int ErrorCode { get => errorCode; set => errorCode = value; }
        public string Email { get => email; set => email = value; }

        public Person()
        {
            this.fio = "Anonymous";
            // ...
        }

        public Person(string fio, DateTime birthday, string address, string phone)
        {
            this.fio = fio;
            Birthday = birthday;
            this.ErrorCode = Errors.LastErrorCode;
            this.address = address;
            this.phone = phone;
            // TODO  add default PassportDate Birthday + 14 years            
        }

        public override string ToString()
        {
            return this.ErrorCode > 0 ? Errors.GetCurrentErrorInfo(this.ErrorCode) : "Person: " + 
                this.Fio + ", " + this.Birthday.ToShortDateString() + ". Address: " + 
                this.Address + ", phone: " + this.Phone + "\tPassport: " + 
                PassportDate.ToShortDateString() + "\te-mail: " + this.email;
        }
    }
}
