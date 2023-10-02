using ASPDemo.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPDemo.Controllers
{
    public static class ApiHelper
    {
        private static string url = "https://localhost:7008";

        private static RestClientOptions options = new RestClientOptions(url) { };
        private static RestClient client = new RestClient(options);

        private static async Task<RestResponse> HttpGetRequest(string request)
        {
            var rrequest = new RestRequest(request, Method.Get);
            RestResponse response = await client.ExecuteAsync(rrequest);
            return response;
        }

        public static async Task<IEnumerable<Person>> RequestPeople()
        {
            try
            {
                string callTask = (await HttpGetRequest("/api/Person/GetAll")).Content;
                IEnumerable<Person> people = JsonConvert.DeserializeObject<IEnumerable<Person>>(callTask);
                return people;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error making HTTP GET request: {ex.InnerException?.Message}");
                return null;
            }
        }

        public static async Task<Person> RequestPersonById(int id)
        {
            if (id < 1)
            {
                Console.WriteLine("Error making HTTP GET request: Invalid Id");
                return null;
            }

            try
            {
                string callTask = (await HttpGetRequest("/api/Person/ById/" + id.ToString())).Content;
                Person person = JsonConvert.DeserializeObject<Person>(callTask);
                return person;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error making HTTP GET request: {ex.InnerException?.Message}");
                return null;
            }
        }

        /* --- Not used --------------------------------
        private static string MakeHttpGetCall()
        {
            var options = new RestClientOptions(url) {};
            var client = new RestClient(options);
            var request = new RestRequest(resource, Method.Get);
            RestResponse response = client.Execute(request);
            return response.Content;
        }

        public static async Task<string> RequestPeopleSerialized()
        {
            try
            {
                string callTask = await MakeHttpGetCallAsync();
                return callTask;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error making HTTP GET request: {ex.InnerException?.Message}");
                return null;
            }
        }*/
    }
}