# JSON Serialization Lab – C#

A C# console application demonstrating JSON serialization and deserialization using Newtonsoft.Json.

---
git a
## Version History

### Task 1 – Create JSON File and Deserialize Single User
- Created `users.json` manually with a single user object
- Defined a `User` class with `Name`, `Age`, and `City` properties
- Used `JsonConvert.DeserializeObject<User>()` to read and print the data

### Task 2 – Add New Entries to JSON Array
- Converted `users.json` from a single object to an array
- Loaded the list, added a new user, and saved it back using `JsonConvert.SerializeObject()`

### Task 3 – Deserialize All Entries with a Loop
- Deserialized the JSON array into a `List<User>`
- Used a `foreach` loop to print all users to the console

### Task 4 – Inheritance
- Created `Admin` class extending `User` with an `AccessLevel` property
- Created `RegularUser` class extending `User` with a `Subscription` property
- Instantiated both types and printed their data to the console

### Task 5 – User Types JSON File
- Created `user_types.json` with users of different access levels
- Deserialized the file into a `List<Admin>` and printed all entries

---

## Technologies Used
- C# .NET Console Application
- Newtonsoft.Json 13.0.4