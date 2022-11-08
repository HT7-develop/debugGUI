using hrtool.HrModel;
using System.Text.Json;

namespace hrtool
{
    internal class HrKoppeling
    {
        private readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
        private readonly HttpClient client = new HttpClient();

        private string baseURL;

        public HrKoppeling(string baseURL)
        {
            this.baseURL = baseURL;
        }

        public IDictionary<string, string>? WerknemerIndex()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = client.GetStringAsync(baseURL + "/employees");

            try
            {
                var jsonString = stringTask.Result;

                IDictionary<string, string>? employeeIndex =
                    JsonSerializer.Deserialize<IDictionary<string, string>>(jsonString);

                if (employeeIndex != null)
                {
                    return employeeIndex;
                }

                Console.WriteLine("Onverwachte response: " + jsonString);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("HR systeem communicatiefout: " + ex.Message);
            }

            return null;

        }

        public int[] Beschikbaarheid(int werknemerId, int jaar, int weekNr)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = client.GetStringAsync(baseURL + "/employee/" + werknemerId + "/availability/" + jaar + "/" + weekNr);

            try
            {
                var jsonString = stringTask.Result;

                AvailabilityModel? availability =
                    JsonSerializer.Deserialize<AvailabilityModel>(jsonString, jsonOptions);

                if (availability != null &&
                    availability.Availability != null &&
                    availability.Availability.Count == 7)
                {
                    int[] beschikbaarheid = new int[7];

                    for (var i = 0; i < 7; i++)
                    {
                        beschikbaarheid[i] = availability.Availability[i];
                    }

                    return beschikbaarheid;
                }

                Console.WriteLine("Onverwachte response: " + jsonString);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("HR systeem communicatiefout: " + ex.Message);
            }

            return new int[0];
        }
    }
}
