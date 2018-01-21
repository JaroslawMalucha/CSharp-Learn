using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("brightness");
        }

        public void ApplyColor(Photo photo)
        {
            Console.WriteLine("color");
        }

        public void ApplyTransparency(Photo photo)
        {
            Console.WriteLine("transparency");
        }
    }
}
