﻿namespace HomeWork.Models
{
    public abstract class Person
    {
        public int Id { get; set; } = 1;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; } 
        public string? Address { get; set; }
    }
}
