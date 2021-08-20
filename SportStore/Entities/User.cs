﻿namespace SportStore.Entities
{
    public abstract class User : BaseEntity
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public double AddressX { get; set; }
        public double AddressY { get; set; }

        protected User()
        {
        }

        protected User(string idNumber, string firstName, string lastName, string password, Point address)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            AddressX = address.X;
            AddressY = address.Y;
        }
    }
}
