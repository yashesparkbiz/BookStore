
using Microsoft.Extensions.Options;
using BookStore1.Data.Repository.Interface;
using BookStore1.Data.Models;

namespace BookStore1.Data.Repository
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
