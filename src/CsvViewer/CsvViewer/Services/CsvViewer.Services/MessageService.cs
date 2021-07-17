using CsvViewer.Services.Interfaces;

namespace CsvViewer.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
