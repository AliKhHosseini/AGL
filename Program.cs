using agl.Data;
using agl.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace agl
{
    class Program
    {


        static void Main(string[] args)
        {


            MainAsync().Wait();


        }

        static async Task MainAsync()
        {
            var urlPath = "http://agl-developer-test.azurewebsites.net/people.json";

            var data = await Repository.GetPeopleAsync(urlPath);

            var People = new People(data);

            People.ShowCatsBasedOnOwnerGender(Gender.Female);
            People.ShowCatsBasedOnOwnerGender(Gender.Male);

 


        }









    }






}

