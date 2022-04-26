using System;
using System.Net.Http;
using System.Threading.Tasks;
using MemeGenerator.Droid.Services;
using MemeGenerator.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(MemeWebClient))]
namespace MemeGenerator.Droid.Services
{
    public class MemeWebClient : IMemeWebClient
    {
        public async Task<string> GetString(string Uri)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync(Uri);

            if( response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }
    }
}
