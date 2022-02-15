using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace leetcode.subjects{
    class TestPushDeer
    {
        private static readonly HttpClient client = new HttpClient();
        
        public async void Run(){
            dynamic res = await Post();
        }
        public async Task<dynamic> Get(){
            var responseString = await client.GetStringAsync("https://api2.pushdeer.com/message/push?pushkey=PDU5890TaomFk637b5eTWUNfvqULif5kz2CW9d3y&text=123");
            Console.WriteLine(responseString);
            return responseString;
        }

        public async Task<dynamic> Post(){
            var values = new Dictionary<string,string>{{ "pushkey", "PDU5890TaomFk637b5eTWUNfvqULif5kz2CW9d3y" }, { "text", "123" }};
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://api2.pushdeer.com/message/push", content);
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
            return responseString;
        }
    }
}