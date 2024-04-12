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
            // // give a few examples as user and assistant
            // chat.AppendUserInput("Is this an animal? Cat");
            // chat.AppendExampleChatbotOutput("Yes");
            // chat.AppendUserInput("Is this an animal? House");
            // chat.AppendExampleChatbotOutput("No");

            // // now let's ask it a question
            // chat.AppendUserInput("Is this an animal? Dog");
            // // and get the response
            // string response = await chat.GetResponseFromChatbotAsync();
            // Console.WriteLine(response); // "Yes"

            // and continue the conversation by asking another
            //chat.AppendUserInput("Is this an animal? Chair");
            // and get another response
            var response = await chat.GetResponseFromChatbotAsync();
            Console.WriteLine(response); // "No"
            chat.AppendUserInput("Escolha outro lugar");
            response = await chat.GetResponseFromChatbotAsync();
            Console.WriteLine(response); // "No"

            return response;
        }

    }
}