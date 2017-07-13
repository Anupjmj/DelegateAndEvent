using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEventExample
    {
   public class VideoEncorder
        {
       public delegate void OnVideoEncodedEventHandler(object sender,EventArgs e);
       public event OnVideoEncodedEventHandler OnEncoded;
       public void VideoEncoder(Video videoObj)
           {
           Console.WriteLine("Video Encoding......");
           Thread.Sleep(30000);
           Console.WriteLine("video is encoded...");
           Console.WriteLine("informing all subscriber classes...");
           Thread.Sleep(1000);
           OnVideoEncoded();
           }
       protected virtual void OnVideoEncoded()
           {
           if(OnEncoded!=null)
               {
               OnEncoded(this, EventArgs.Empty);
               }
           }
        }
   
    }
