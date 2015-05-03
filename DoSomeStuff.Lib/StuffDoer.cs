using System;
using System.Threading.Tasks;

namespace DoSomeStuff.Lib
{
    public class StuffDoer
    {
        public string GetStuff()
        {
            Task.Delay(TimeSpan.FromSeconds(5)).Wait();
            return "abracadabra";
        }

        public async Task<string> GetStuffAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return "abracadabra";
        }
    }
}
