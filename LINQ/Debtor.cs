namespace LINQ;

using System;



    public class Debtor
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }

        public Debtor(string fullName, DateTime birthDate, string phoneNumber, string email, string address, int debt)
        {
            FullName = fullName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Debt = debt;
        }

        public override string ToString()
        {
            return $"{FullName}, {BirthDate.ToShortDateString()}, {PhoneNumber}, {Email}, {Address}, {Debt}";
        }
    }
