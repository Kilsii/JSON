using Newtonsoft.Json;
using System;
using System.IO;

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

        // Read and deserialize the existing list
        string jsonData = File.ReadAllText(filePath);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

        // Add a new user
        users.Add(new User { Name = "Sarah", Age = 15, City = "Porthara" });

        // Save the updated list back to the file
        string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(filePath, updatedJson);

        Console.WriteLine("New user added successfully!");
    }
}