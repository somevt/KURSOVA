using System;

namespace KURSOVA
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string surname, string password, string email, bool isAdmin)
        {
            Name = name;
            Surname = surname;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }

        public bool CheckIfAdmin()
        {
            return IsAdmin;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} - {(IsAdmin ? "Admin" : "User")}";
        }
    }
}
