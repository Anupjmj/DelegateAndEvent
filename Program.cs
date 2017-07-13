using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventExample
    {
    class Program
        {
        static void Main(string[] args)
            {
            var video = new Video() {Title="Video" };
            var videoEncoder = new VideoEncorder();
           
            MailService mailS = new MailService(videoEncoder);
            MessageService messageSer = new MessageService(videoEncoder);
            videoEncoder.VideoEncoder(video);
            Console.Read();
            }
        }
    public class MailService
        {
          public  MailService(VideoEncorder ve)
            {
            ve.OnEncoded += OnVideoEncoded;
            }
        public void OnVideoEncoded(object source,EventArgs e)
              {
              Console.WriteLine("Mail Sent");
              }
        }
    public class MessageService
        {
        public MessageService(VideoEncorder ve)
            {
            ve.OnEncoded += OnVideoEncoded;
            }
        public void OnVideoEncoded(object source, EventArgs e)
            {
            Console.WriteLine("Message Sent");
            }
        }
    }
