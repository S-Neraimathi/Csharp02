using System.Net.Http;
using System.Reflection.PortableExecutable;

class GetdataApi{
    public void getdataapi(){
        string apiurl = "https://jsonplaceholder.typicode.com";

        using (HttpClient client = new HttpClient())
        {
            try{
                HttpResponseMessage response = client.GetAsync(apiurl).GetAwaiter().GetResult();

                response.EnsureSuccessStatusCode();

                string responceBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                Console.WriteLine(responceBody);


            }
            catch(HttpRequestException e){
                Console.WriteLine($"Request error : {e.Message}");

            }
        }
    }
}