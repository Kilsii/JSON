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

    static void Main(string[] args)
    {
        string filePath = "users.json";
        string jsonData = File.ReadAllText(filePath);

        // Deserialize into a list
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

        // Loop through and print each user
        foreach (User user in users)
        {
            Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, City: {user.City}");
        }
    }
}