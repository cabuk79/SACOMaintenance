using Microsoft.Extensions.Configuration;
using Vonage.Messaging;
using Vonage.Request;

namespace SACOMaintenance.Blazor.Server.Data
{
    public class SmsService
    {
        public IConfiguration Configuration { get; set; }
        public SmsService(IConfiguration config)
        {
            Configuration = config;
        }

        public SendSmsResponse SendSms(string to, string from, string text)
        {
            var apiKey = "0f24de34"; // Configuration["VONAGE_API_KEY "];
            var apiSecret = "lwuDZaDN8h5R3t9o"; // Configuration["VONAGE_API_SECRET"];
            var creds = Credentials.FromApiKeyAndSecret(apiKey, apiSecret);
            var client = new SmsClient(creds);
            var request = new SendSmsRequest
            {
                To = to,
                From = from,
                Text = text
            };
            return client.SendAnSms(request);
        }
    }
}
