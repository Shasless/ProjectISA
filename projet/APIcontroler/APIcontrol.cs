using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace projet.APIcontroler
{
    class APIcontrol
    {
        private static readonly HttpClient Client = new HttpClient();
        public Root objectRes { get; set; }
        
        
        public  async void GetInfo(string currency)
        {
                objectRes = new Root();
           
                var responseBody = Client.GetAsync("https://api.lunarcrush.com/v2?data=assets&key=lnfht57eiirp715eqwevoo&symbol="+currency+"&interval=hour&data_points=24").Result;

                var res = await responseBody.Content.ReadAsStringAsync();
                if (res == "{\"error\":\"We could not find any coins matching the requested ids or symbols\"}")
                {
                    responseBody = Client.GetAsync("https://api.lunarcrush.com/v2?data=assets&key=lnfht57eiirp715eqwevoo&symbol="+"BTC"+"&interval=hour&data_points=24").Result;
                    res = await responseBody.Content.ReadAsStringAsync();

                }
                objectRes = JsonConvert.DeserializeObject<Root>(res);
                
                
            
        }
        
        public static void test(string[] args)
        {
            var p = new APIcontrol();
            p.GetInfo("BTC");
            p.GetInfo("22");
            try
            {
                var d = p.objectRes.data[0];
                //Console.WriteLine(d[0].name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Currency doesn't exist");
            }
        }
    }
}