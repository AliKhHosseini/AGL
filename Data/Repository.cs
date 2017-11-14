using agl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace agl.Data
{
    public class Repository
    {
        static HttpClient client = new HttpClient();
        //static string path = "http://agl-developer-test.azurewebsites.net/people.json"'
        public Repository()
        {
           // client.BaseAddress = new Uri(path); 
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    public static async Task<IEnumerable<Person>> GetPeopleAsync(string path)
    {


        IEnumerable<Person> persons = null;
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            persons = await response.Content.ReadAsAsync<IEnumerable<Person>>();
        }
        return persons;
    }




}
}
