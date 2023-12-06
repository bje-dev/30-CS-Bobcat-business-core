using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace SL.Services
{

    internal sealed class TelegramManager
    {
        private readonly static TelegramManager _instance = new TelegramManager();
        private readonly string botToken;
        private readonly string chatId;

        public static TelegramManager Current
        {
            get { return _instance; }
        }

        private TelegramManager()
        {
            
            botToken = ConfigurationManager.AppSettings["Token"];
            chatId = ConfigurationManager.AppSettings["ChatId"];
        }

        public async Task SendMessage(string messageText)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string apiUrl = $"https://api.telegram.org/bot{botToken}/sendMessage";

                var content = new StringContent($"chat_id={chatId}&text={Uri.EscapeDataString(messageText)}", Encoding.UTF8, "application/x-www-form-urlencoded");

                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si el código de estado no es de éxito.

                // Puedes agregar lógica adicional después de asegurar el éxito, si es necesario.
            }
        }
    }

}
