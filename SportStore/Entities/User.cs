﻿using SportStore.Enums;

namespace SportStore.Entities
{
    public abstract class User : BaseEntity
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public double AddressX { get; set; }
        public double AddressY { get; set; }
        public PermissionsLevel permissionsLevel { get; set; }

        protected User()
        {
        }

        protected User(string idNumber, string firstName, string lastName, string password, Point address, PermissionsLevel permissions = PermissionsLevel.Watch)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            AddressX = address.X;
            AddressY = address.Y;
            permissionsLevel = permissions;
        }
    }
}
