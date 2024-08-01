using System.Collections.Generic;
class Dictionaries{
    public void Dictionary(){
      Dictionary<int, string> dic01 = new Dictionary<int, string>();

      dic01.Add(12, "hi");
      dic01.Add(13, "Hello");
      dic01.Add(14, "Dance");

      foreach(KeyValuePair<int, string> ele1 in dic01){
        Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);


      }
      Console.WriteLine();
    
      Dictionary<string, string> dict2 = new Dictionary<string, string>(){{"Hi", "Hello"}, {"Dog", "Barks"}, {"Do", "Dance"}};

       foreach(KeyValuePair<string, string> ele2 in dict2){
        Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);


      }


    }
}
