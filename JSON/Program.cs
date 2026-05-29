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
        string filePath = "user_types.json";
        string jsonData = File.ReadAllText(filePath);

        // Deserialize as a list of Admin (contains all fields)
        List<Admin> admins = JsonConvert.DeserializeObject<List<Admin>>(jsonData);

        foreach (Admin user in admins)
        {
            Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, City: {user.City}, Access: {user.AccessLevel}");
        }
    }
}