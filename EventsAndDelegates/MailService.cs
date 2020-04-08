using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MailService //sends email once video is encoded
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) //event handler, delegate -- contract
        {
            Console.WriteLine("MailService: Sending an email..."+ e.Video.Title);
        }
    }
}
