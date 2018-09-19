using System.Collections.Generic;

namespace Polymorphism
{

    public class VideoEncoder
    {
        // This type dependence affects testability, so we must isolate it to unit test. Better to send 
        // an interface to the constructor of VideoEncoder.
        // private readonly MailService _mailService;

        private readonly IList<INotificationChannel> _notificationChannels = new List<INotificationChannel>();

        public VideoEncoder()
        {
            
        }

        public void Encode(Video video)
        {
            // What if we want to send a text instead of an email here? We need to think of the notification channel
            // (text, email, notification) as an abstraction.
            foreach (var channel in _notificationChannels)
            {
                // This is POLYMORPHIC because at run time, depending on the Type that is passed in (MailNotificationChannel
                // or SmsNotificationChannel) different 'Send' methods are called.
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
