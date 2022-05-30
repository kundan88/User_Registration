﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class UserRegistrationRegex
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public void ValidFirstName(string firstName)
        {
            Console.WriteLine("First name - " + firstName);
            if (FirstName.IsMatch(firstName))
                Console.WriteLine($"{firstName} is valid");
            else
                Console.WriteLine($"{firstName} is Invalid");
        }

        public void ValidLastName(string lastName)
        {
            Console.WriteLine("Last name - " + lastName);
            if (LastName.IsMatch(lastName))
                Console.WriteLine($"{lastName} is valid");
            else
                Console.WriteLine($"{lastName} is Invalid");
        }
        public void ValidEmail(string email)
        {
            Console.WriteLine("Email - " + email);
            if (Email.IsMatch(email))
                Console.WriteLine($"{email} is valid");
            else
                Console.WriteLine($"{email} is Invalid");
        }
    }
}

