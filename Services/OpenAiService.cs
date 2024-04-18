using Microsoft.Extensions.Options;
using TipsOnPoints.Configuration;

namespace TipsOnPoints.Services
{
    public class OpenAiService : IOpenAiService
    {
        public readonly OpenAIConfig _openAiConfig;
        public OpenAiService(IOptionsMonitor<OpenAIConfig> optionsMonitor)
        {
            _openAiConfig = optionsMonitor.CurrentValue;
        }

        public async Task<string> GetNewCard(string text)
        {
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage(text);
            var response = await chat.GetResponseFromChatbotAsync();
            return response; 
        }

    }
}