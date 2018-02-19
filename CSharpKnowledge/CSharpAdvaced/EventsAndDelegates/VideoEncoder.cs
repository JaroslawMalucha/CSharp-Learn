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

            //subscribe to the event, essentially just add the objects method pointer to the delegate(event is of type delegate) for delegate multicast when event trigerred
            encoder.VideoEncoded += mailService.OnVideoEncoded; 
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            encoder.VideoEncoding += mailService.OnVideoEncoding;
            encoder.VideoEncoding += messageService.OnVideoEncoding;

            // run the method that will internally trigger the event that is delegate multicast call of all the subscribing methods
            encoder.EncodeVideo(video);
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Events in C#
        // - events are declared and raised in a class and associated with..
        //  ...the event handlers using delegates within the sane class or some other class
        // - jm: event is a public interface for a delegate declared in the class, so outsider classes can subscribe to the event(associate their own methods or methods accessable by them with that delegate, i.e event)
        // - two entities are involved in that dance: Publisher and Subscriber
        // - Publisher - an object that contains the definition of the event and the delegate
        // - Subscriber - an object that accepts the event and provides an event handler
        // - EventHandler - a method assigned by the subscriber or anothe object to the publishers event delegate
        // - event raising wrapper - (optional) method in the event owner object that will raise the event; by convention should be [protected virtual void On[EventName]() ]

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
        // - note that the object that is the owner of the event handler ...
        //  ...does not have to be aware of the event or of the fact that his method was assigned...
        //  ...to an event, e.g. the [testEventsAndDelegates()] method is assigning...
        //  ...eventhandlers to specific events so the event owner does not have to be passed...
        //  ...to the event subscriber, this way you have less coupling...
        //  ...e.g. in VBA this is not possible and subscriber must be associated with the event owner.


        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded; // event with custom delegate

        public event EventHandler EncoderCreated; // event with built in EventHandler delegate
        public event EventHandler<Video> VideoEncoding; // event with built in GENERIC EventHandler<T> delegate


        public VideoEncoder()
        {
            if (EncoderCreated != null)
                EncoderCreated(this, EventArgs.Empty);
            // EncoderCreated?.Invoke(this, EventArgs.Empty); //shorter way
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

        protected virtual void OnVideoEncoding(Video video) // the signature here is the convention
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
