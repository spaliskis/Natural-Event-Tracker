using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EventInfoLibrary
{
    public static class GetData
    {

        public static List<Event> GetItems(string response)
        {
            List<Event> eventInfo = new List<Event>();
            
                if (string.IsNullOrWhiteSpace(response)) 
                { 
                    return null; 
                }
                else if (response[0] == '{' && response[response.Length -1] == '}' )
                {
                    var deserializedJson = JsonConvert.DeserializeObject<dynamic>(response);
                    var events = deserializedJson.events;
                    if (events == null)
                    {
                        return null;
                    }

                    else
                    {

                        for (int i = 0; i < events.Count; i++)
                        {
                            Console.WriteLine((string)events[i].title);
                            var geoms = events[i].geometries;
                            if (events[i].geometries[0].coordinates[0] is JArray)
                            {
                                Console.WriteLine(events[i].geometries[geoms.Count - 1].coordinates[0][0][0]);
                                Console.WriteLine(events[i].geometries[geoms.Count - 1].coordinates[0][0][1]);
                                Console.WriteLine();
                                Event item = new Event((string)events[i].title, (DateTimeOffset)events[i].geometries[geoms.Count - 1].date, (string)events[i].geometries[geoms.Count - 1].coordinates[0][0][0], (string)events[i].geometries[geoms.Count - 1].coordinates[0][0][1]);
                                eventInfo.Add(item);
                            }
                            else
                            {
                                Console.WriteLine(events[i].geometries[geoms.Count - 1].coordinates[0]);
                                Console.WriteLine(events[i].geometries[geoms.Count - 1].coordinates[1]);
                                Console.WriteLine();
                                Event item = new Event((string)events[i].title, (DateTimeOffset)events[i].geometries[geoms.Count - 1].date, (string)events[i].geometries[geoms.Count - 1].coordinates[0], (string)events[i].geometries[geoms.Count - 1].coordinates[1]);
                                eventInfo.Add(item);

                            }
                        }
                        return eventInfo;
                    }
                }

                else
                {
                    return null;
                }

        }

        public static async Task<string>getAPI(string url)
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            return response;
        }
    }



    public class Event
    {
        public string title;
        public DateTimeOffset date;
        public string coordinate1;
        public string coordinate2;

        public Event(string titleName, DateTimeOffset dateName, string coordinate1Name, string coordinate2Name)
        {
            title = titleName;
            date = dateName;
            coordinate1 = coordinate1Name;
            coordinate2 = coordinate2Name;
        }
    }

}