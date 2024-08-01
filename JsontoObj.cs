using System.Text.Json;

class JsontoObj{
    public void jsontoobj(){
        string jsonString = @"{
             ""Name"" : ""Raja"",
             ""Isstudent"" : false,
             ""Hobbies"" : [""Reading"", ""Dancing""],
             ""Address"" : {
                ""City"" : ""Erode"",
                ""Pincode"" : 23456
                }
        }";

        Person person = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine($"Name : {person.Name}");
        Console.WriteLine($"Isstudent : {person.Isstudent}");
        Console.WriteLine("Hobbies : "+ string.Join(", ", person.Hobbies));
        Console.WriteLine($"City : {person.Address.City}");
        Console.WriteLine($"Pincode : {person.Address.Pincode}");
    }

        public class Person
        {
            public string Name { get; set; }
            public bool Isstudent { get; set; }
            public List<string> Hobbies { get; set; }
            public Address Address { get; set; }
        }

            public class Address
            {
                public string City { get; set; }
                public int Pincode { get; set; }
            }


    }
