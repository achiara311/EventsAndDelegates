using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder //Publisher/Event handler
    {
        //1. Define a delegate first (Video Encoder is our publisher -- events are located within publishers, aka event senders)
        //2. Define an event based on that delegate
        //3. Raise the event

       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //delegate, holds reference to function -- void VideoEncodedEventHandler

       //TWO FORMS OF DELEGATES

       //EventHandler (what we've been using)
       //EventHandler <TEventArgs> (generic)

        public event EventHandler<VideoEventArgs> VideoEncoded; //event, VideoEncoded should match delegate's VideoEncoded
        //public event EventHandler<VideoEventArgs> VideoEncoded = public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event EventHandler VideoEncoding; //Basic syntax if youre not sending any additional info 
        public void Encode(Video videoOkay)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(videoOkay);
        }

        protected virtual void OnVideoEncoded(Video videoOkay) // OnVideoEncoded() should match event 
        {
            //to check if there are subscribers
            if (VideoEncoded != null) //taking from event //if its not empty, means someone subscribed
            {
               // VideoEncoded(this, EventArgs.Empty); //EventArgs.Empty used when you dont want to send additional data
                //"this" refers to (object source) above within the delegate

                //PREVIOUS

                //NOW 
                if (VideoEncoded != null)
                {
                    VideoEncoded(this,new VideoEventArgs(){Video = videoOkay }); //have to create new object (VideoEventArgs) 
                    //because it's pulling additional info from VideoEventArgs class
                }
            }

        }
    }
}
