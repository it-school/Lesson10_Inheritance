using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Person
    {
        string fio;
        DateTime birthday;
        string address;
        string phone;
        protected DateTime passportDate;

        public string Fio { get => fio; set => fio = value; }
        public DateTime Birthday { get => birthday; set => birthday = ((DateTime.Now.Year - value.Year) <= Constants.MaxPersonAge ? value : Errors.ErrorDateTime(1)); }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime PassportDate { get => passportDate; set => passportDate = value; }

        public Person()
        {
        }

        public Person(string fio, DateTime birthday, string address, string phone)
        {
            this.fio = fio;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
        }

        public override string ToString()
        {
            return Errors.LastErrorCode > 0 ? Errors.GetCurrentErrorInfo() : "Person: " + this.Fio + ", " + this.Birthday.ToShortDateString() + ". Address: " + this.Address + ", phone: " + this.Phone + "\tPassport: " + PassportDate.ToShortDateString();
        }
    }
}
