using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.EventsAndDelegates
{

    public class EventsAndDelegates
    {
        public static void testEventsAndDelegates()
        {
            var video = new Video { Title = "Lion King" };
            var encoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();

            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            encoder.EncodeVideo(video);
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // INSIDE THE EVENT RAISING CLASS
        // 1 - Declare a delegate - it defines the subscribers event handler method signature
        // 2 - Declare an event based on that delegate
        // 3 - (optional) Create a method that wraps the Event Raising code
        // 3 - Raise the event

        // OUTSIDE THE EVENT RAISING CLASS - INSIDE THE SUBSCRIBER CLASSES    
        // 4 - Create Event Handler Methods that abide to the delegate's signature
        // 5 - Subscrbe to the event (outside the class) using the delegate

        //EVENT DELEGATE:
        // - contract between Publisher and Subscriber of the event
        // - determines the signature of the event handler method in Subscriber

        // SUBSCRIPTION:
        // - by exposing the subscription process and making it explicit...
        //  ...the compiler can check the validity of the handler
        //  ...in VBA you would not even know that the handler...
        //  ...is not being reached by the firing event since subscription is implicit and done by the framework


        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler EncoderCreated;
        public event EventHandler<Video> VideoEncoding;


        public VideoEncoder()
        {
            if (EncoderCreated != null)
                EncoderCreated(this, EventArgs.Empty);
        }

        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Video Encoder: encoding video...");
            System.Threading.Thread.Sleep(1000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) // the signature here is the convention
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs {Video = video});
                //VideoEncoded(this, video);
                //VideoEncoded(this, EventArgs.Empty);
        }

        protected virtual void OnVideoEncodeding(Video video) // the signature here is the convention
        {
            if (VideoEncoding != null)
                VideoEncoding(this, video);
            //VideoEncoded(this, video);
            //VideoEncoded(this, EventArgs.Empty);
        }

    }

    public class Video{ public string Title; }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service: video encoded - " + args.Video.Title);
        }
        public void OnVideoEncoding(object source, Video args)
        {
            Console.WriteLine("Mail Service: video encoding - " + args.Title);
        }
    }


    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message service: video encoded - " + args.Video.Title);
        }
        public void OnVideoEncoding(object source, Video args)
        {
            Console.WriteLine("Mail Service: video encoding - " + args.Title);
        }
    }
}
