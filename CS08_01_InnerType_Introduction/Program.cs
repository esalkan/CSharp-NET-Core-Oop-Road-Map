using System.Threading.Channels;

namespace CS08_01_InnerType_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             *  - A type defined within a class, struct, or interface is called a nested type. For example
             *  - Bir sınıf, yapı veya arabirim içinde tanımlanan bir türe iç içe tür denir. Örneğin
             *
             *      public class Container
             *      {
             *          class Nested
             *          {
             *              Nested(){}
             *          }
             *      }
             *
             *  - "Regardless of whether the outer type is a class, interface, or struct, nested types default to private;
             * they are accessible only from their containing type. In the previous example, the Nested class is
             * inaccessible to external types.
             *
             *  - Dış türün bir sınıf, arabirim veya yapı olmasına bakılmaksızın, iç içe türler varsayılan olarak özeldir;
             * bunlara yalnızca içeren türlerinden erişilebilir. Önceki örnekte, Nested sınıfına harici türler
             * tarafından erişilemez.
             *
             * Nested types of a class can be
             *  - public,
             *  - protected,
             *  - internal,
             *  - protected internal,
             *  - private or
             *  - private protected.
             */

            // Creating an instance of Nested  type
            Car.Togg nested = new Car.Togg();
            nested.CarType = "SUV";
            Console.WriteLine(nested.CarType);

            // can not access
            // Car car = new Car();
            // car.CarType;
        }
    }

    public class Container
    {
        class Nested
        {
            Nested(){}
        }
    }
    
    // The following example makes the Nested class public:
    // Aşağıdaki örnek, Nested sınıfını herkese açık (public) hale getirir:
    public class Bus
    {
        /*
         * Nested types of a class can be:
         * Bir sınıfın iç içe türleri şunlar olabilir:
         *  - public,
         *  - protected,
         *  - internal,
         *  - protected internal,
         *  - private or
         *  - private protected.
         */
        public class MiniBus
        {
            MiniBus()
            {
                
            }
        }
    }

    public class Car
    {
        public class Togg
        {
            private Car _parent;
            private string _carType;

            public string CarType
            {
                get
                {
                    return this._carType;
                }
                set
                {
                    this._carType = value;
                    Console.WriteLine("Car Type Set as : " + value);
                }
            }

            public Togg()
            {
                // Constructor for Togg Class    
            }

            public Togg(Car parent)
            {
                this._parent = parent;
            }

        }
    }
}