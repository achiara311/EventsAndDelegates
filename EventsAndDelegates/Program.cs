using System;

namespace EventsAndDelegates
{
    class Program
    { //events are list of pointers to methods
        static void Main(string[] args)
        {
            var ourVideo = new Video(){Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; 
            //+= registers Event Handler (mandatory)
            //Uses raised event (OnVideoEncoded)
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //no brackets() NOT CALLING METHOD AT ALL, just a reference or pointer

            videoEncoder.Encode(ourVideo);
        }
    }
}
