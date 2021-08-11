using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program6;

namespace Program6
{
    class Http_Request
    {
        public class Http_Response
        {
            public string kind { get; set; }
            public string title { get; set; }
            public string link { get; set; }
        }
        public void httpRequest()
        {
            Console.Write("Enter Search Key : ");
            string searchKey = Console.ReadLine();
            Program6.APICall call = new APICall();
            string apiKey = call.Key;
            string cx = call.Credential;
            WebRequest req = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + apiKey + "&cx=" + cx + "&q=" + searchKey);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream dataStream = res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //Console.WriteLine(responseFromServer);
            reader.Close();
            dataStream.Close();
            res.Close();
            dynamic value = JsonConvert.DeserializeObject(responseFromServer);
            //Console.WriteLine(value.items);
            var list = new List<Http_Response>();
            if(value.items.Count == 10)
            {
                for(int i=0;i<10;i++)
                {
                    list.Add(new Http_Response()
                    {
                        kind = value.items[i].kind,
                        title = value.items[i].title,
                        link = value.items[i].link
                    });
                }
            }
            else
            {
                for (int i = 0; i < value.items.Count; i++)
                {
                    list.Add(new Http_Response()
                    {
                        kind = value.items[i].kind,
                        title = value.items[i].title,
                        link = value.items[i].link
                    });
                }
            }
            foreach(var l in list)
            {
                Console.WriteLine("Kind : {0}\nTitle : {1}\nLink : {2}\n", l.kind, l.title, l.link);
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            Http_Request ob = new Http_Request();
            ob.httpRequest();
        }
    }
}
