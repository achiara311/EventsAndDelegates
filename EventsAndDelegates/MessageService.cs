using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MessageService
    {
        /*public void OnVideoEncoded(object source, EventArgs args) //we're raising/activating this event from the publisher, subscribing to the event
        {
            Console.WriteLine("MessageService: Sending a text message..." );
        }*/

        //NOW WITH VIDEOEVENTARGS

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message..."+ e.Video.Title);
        }
    }
}
