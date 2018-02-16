using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, System.Action<Photo> filterHandleer)
        {
            var photo = new Photo(path);

            filterHandleer(photo);
        }
        public void Process(string path, PhotoFilterHandler filterHandleer)
        {
            var photo = new Photo(path);

            filterHandleer(photo);
        }

        public void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("removing red eye");
        }


        public static void testDelegates()
        {
            var filters = new PhotoFilters();
            {
                //PhotoProcessor.PhotoFilterHandler filterHandler;
                Action<Photo> filterHandler = null;

                // this is a delegate multicast - assigning multiple methods to one delegate instance
                filterHandler += filters.ApplyBrightness;

                filterHandler += filters.ApplyColor;
                filterHandler += filters.ApplyTransparency;
                var processor = new PhotoProcessor();
                filterHandler += processor.RemoveRedEye;

                processor.Process("photo.jpg", filterHandler);
            }
            {
                PhotoProcessor.PhotoFilterHandler filterHandler = null;
                filterHandler += filters.ApplyBrightness;

                filterHandler += filters.ApplyColor;
                filterHandler += filters.ApplyTransparency;
                var processor = new PhotoProcessor();
                filterHandler += processor.RemoveRedEye;

                processor.Process("photo.jpg", filterHandler);
            }
        }


    }
}
