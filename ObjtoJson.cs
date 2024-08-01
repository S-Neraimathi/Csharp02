using System.IO.Pipes;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text.Json;
using System.Collections.Generic;

class ObjtoJson{
    public void objtojson(){
        var person = new Person {
            Name = "Raja",
            Isstudent = false,
            Hobbies = new List<string>{"reading", "dancing", "cooking"},
            Address= new Address {
                City= "Erode",
                Pincode = 123456

            }
        };

        string jsonString = JsonSerializer.Serialize(person, new JsonSerializerOptions {WriteIndented = true});
        Console.WriteLine(jsonString);
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