using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpFundamentals.IEnumerableApp
{
    public class car
    {
        private int year;
        private string make;

        public car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
    }

    public class cars : IEnumerable, IEnumerable<car>
    {
        public static void test()
        {
            ////////////
            // IMPLEMENTING IEnumerable and IEnumerator
            ///////////
            cars mycars = new cars();
            foreach (var car in mycars)
            {
                Console.WriteLine(car.Make + " " + car.Year);
            }

            foreach (car car in (System.Collections.Generic.IEnumerable<car>)mycars)
            {
                Console.WriteLine(car.Make + " " + car.Year);
            }

            foreach (object item in (System.Collections.IEnumerable)mycars)
            {
                Console.WriteLine(((car)item).Make + " " + ((car)item).Year);
            }
        }


        // IEnumerable 
        // - an interface implemented all enumerable/loopable collections 
        //  --> can use with foreach loop
        //  --> readonly access to elements
        // - an interface that defines one method GerEnumerator which returns...
        //  ...an IEnumerator interface, which allows readonly access to a collection
        // - IEnumerable type is itself as an object:
        //   - read-only, cant .Add items
        //   - some type like a List or array that you can loop through; like a view on a table
        // https://stackoverflow.com/questions/11296810/how-do-i-implement-ienumerablet
        //https://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
        //http://james-ramsden.com/implement-ienumerable-c/
        //https://msdn.microsoft.com/en-us/library/s793z9y2(v=vs.110).aspx

        private car[] carlist;

        //Create internal array in constructor.
        public cars()
        {
            carlist = new car[6]
            {
                new car("Ford",1992),
                new car("Fiat",1988),
                new car("Buick",1932),
                new car("Ford",1932),
                new car("Dodge",1999),
                new car("Honda",1977)
            };
        }

        // DEFAULT IMPLEMENTATION
        //IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    return carlist.GetEnumerator();
        //}
        //IEnumerator<car> IEnumerable<car>.GetEnumerator()
        //{
        //    return (IEnumerator<car>)this.GetEnumerator();
        //    //new List<car>().GetEnumerator(); // you can get a generic Enumerator from a GENERIC List but not from a non-generic array
        //}

        // CUSTOM IMPLEMENTATION
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(carlist);
        }
        IEnumerator<car> IEnumerable<car>.GetEnumerator()
        {
            return new MyEnumeratorGENERIC(carlist);
        }




        //private enumerator class NON-GENERIC -> enumerator will be of type object as declared by the non-generic IEnumerable interface
        private class MyEnumerator : IEnumerator
        {
            public car[] carlist;
            int position = -1;

            //constructor
            public MyEnumerator(car[] list)
            {
                carlist = list;
            }
            private IEnumerator getEnumerator()
            {
                return (IEnumerator)this;
            }


            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < carlist.Length);
            }

            //IEnumerator
            public void Reset()
            { position = -1; }

            //IEnumerator
            public object Current
            {
                get
                {
                    try
                    {
                        return carlist[position];
                    }

                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }  //end nested class
        private class MyEnumeratorGENERIC : IEnumerator<car>
        {
            public car[] carlist;
            int position = -1;

            //constructor
            public MyEnumeratorGENERIC(car[] list)
            {
                carlist = list;
            }
            private IEnumerator<cars> getEnumerator()
            {
                return (IEnumerator<cars>)this;
            }


            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < carlist.Length);
            }

            //IEnumerator
            public void Reset()
            { position = -1; }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            //IEnumerator
            public car Current
            {
                get
                {
                    try
                    {
                        return carlist[position];
                    }

                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => (object)this.Current;
        }  //end nested class
    }
}