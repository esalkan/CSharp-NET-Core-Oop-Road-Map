﻿namespace CS01_40_Loops_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General Usage | Genel Kullanım
            string[] fruits = { "Watermelon", "Apple", "Banana", "Grape", "Coconat" };

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            #endregion

            #region Uygulama 1 | Example 1 
            /*
             * int veri tipinde bir dizi oluşturalım , kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin,
             * ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların toplamlarını
             * ve ortalamasını ekrana yazdıran bir uygulama yazalım.
             *
             * Let's create an array of int data type, let our user inform us how many elements the array will have,
             * and assign values to the fields in the array. Next, let's write an application that prints
             * the sums and averages of the elements in the array.
             */
            Console.WriteLine("-----> Example 1 <-----");
            Console.WriteLine("Please enter the length of the dataset you want to create");
            Console.WriteLine("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz");
            
            string example1ArrayLength = Console.ReadLine();
            int example1ArrayLengthInt = int.Parse(example1ArrayLength);

            int[] example1Array = new int[example1ArrayLengthInt];

            for (int exampleCounter = 0; exampleCounter < example1Array.Length; exampleCounter++)
            {
                Console.WriteLine("{0}. index e denk gelen değeri giriniz", exampleCounter);
                Console.WriteLine("Enter the value corresponding to index {0}.", exampleCounter);
                example1Array[exampleCounter] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Congratulations, you have filled all the fields in the array.");
            Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz");

            Console.WriteLine("The values in the array and the total, average value are as follows.");
            Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir.");

            int example1Sum = 0, exaple1Average = 0;
            foreach (int item in example1Array)
            {
                Console.WriteLine(item);
                example1Sum = example1Sum + item;
            }
            Console.WriteLine("+----------------------------");

            Console.WriteLine(example1Sum);

            Console.WriteLine("Number of elements in the array : {0}", example1Array.Length);
            Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", example1Array.Length);
            
            exaple1Average = example1Sum / example1Array.Length;
            
            Console.WriteLine("Average : {0}", exaple1Average);
            Console.WriteLine("Ortalama : {0}", exaple1Average);
            #endregion
            
            #region Uygulama 2 | Example 2
            /* 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10
             * arasındaki değerler ile dolduralm. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve
             * ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım.
             *
             * Let's create an int array with 20 elements. Let's fill our values with the next function of
             * the random class with values between 1 and 10. Then let's print our elements in the array to
             * the screen and find how many 4 values are in the related array.
             */ 
            
            Console.WriteLine("-----> Example 2 <-----");
            Random Rnd = new Random();

            int[] example2Array = new int[20];
            for (int exaple2Counter = 0; exaple2Counter < example2Array.Length; exaple2Counter++)
            {
                example2Array[exaple2Counter] = Rnd.Next(1, 10);
            }

            int example2Find = 0;

            foreach(int item in example2Array)
            {
                Console.WriteLine(item);
                if (item == 4)
                    example2Find++;
            }
            Console.WriteLine("The value 4 in the array is {0}.", example2Find);
            Console.WriteLine("Dizi içindeki 4 değeri {0} adettir.", example2Find);
            #endregion

            
        }
    }
}