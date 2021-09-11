using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

namespace Parser_1.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            //url = $"{settings.BaseUrl}/{settings.Prefix}/";
            url = $"{settings.BaseUrl}";
        }
        string source = null;
        public async Task<string> GetSourceByPage()
        {
           // var currentUrl = url.Replace("{CurrentId}", id.ToString());
           //var response = await client.GetAsync(currentUrl);
            var response = await client.GetAsync(url);
            if (response!=null&&response.StatusCode==HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
