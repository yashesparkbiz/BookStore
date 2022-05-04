using Microsoft.Extensions.Options;

namespace BookStore1.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IOptionsMonitor<NewBookAlertConfig> _newBookAlertconfiguration;
        public MessageRepository(IOptionsMonitor<NewBookAlertConfig> newBookAlertconfiguration)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration;
        }
        public string GetName()
        {
            return _newBookAlertconfiguration.CurrentValue.AppName;
        }
    }
}
