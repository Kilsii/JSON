using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    public class Admin : User
    {
        public string AccessLevel { get; set; }
    }

    
    public class RegularUser : User
    {
        public string Subscription { get; set; }
    }

    static void Main(string[] args)
    {
       
        Admin admin = new Admin { Name = "Kilsi", Age = 18, City = "Siaulai", AccessLevel = "Admin" };
        RegularUser regular = new RegularUser { Name = "Sarah", Age = 15, City = "Porthara", Subscription = "Free" };

        Console.WriteLine($"Admin - Name: {admin.Name}, Age: {admin.Age}, City: {admin.City}, Access: {admin.AccessLevel}");
        Console.WriteLine($"User - Name: {regular.Name}, Age: {regular.Age}, City: {regular.City}, Subscription: {regular.Subscription}");
    }
}