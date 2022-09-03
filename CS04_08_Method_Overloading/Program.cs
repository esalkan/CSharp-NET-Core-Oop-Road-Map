namespace CS04_08_Method_Overloading
{
    class Password
    {
        static void Main(string[] args)
        {
	        
            /*
			 * METHOD OVERLOADING
			 * 
			 *	- Method overloading is a feature that allows us to have more than one method
			 * with the same name, so long as we use different parameters.
			 * 
			 *	- It is the abilityto create multiple methods of the same name with different implementation
			 *  - It improves the code readability and re-usability.
			 *	- It is easy to remember one method name instead of remembering multiple names.
			 *	- Overloaded methods give programmers the flexibily to call similar method with
			 * different types of data.
             *
             * 4 Rules Need To Remember About Method Overloading In which case we can method Overloading and tricks.
             *
             * 1- Number of parameters
             *		methodName(int, int)
             *		methodName(int, int, int)
             *
             * 2- Data Type Of Parameters
             *		methodName(int, int)
             *		methodName(int, float)
             *
             * 3- Sequence of Data Type Parameters
             *		methodName(int, float)
             *		methodName(float, int)
             *
             * 4- Invalid Case - Not Method Overloading
             *		int methodName(int, int)
             *		float methodName(int, int)
             *
             * ---------------------------------------------------------------------------------------------------------
             * 
             * METOD AŞIRI YÜKLENMESİ
             * 
             * - Metot aşırı yükleme, farklı parametreler kullandığımız sürece aynı isimde birden fazla metoda sahip
             * olmamızı sağlayan bir özelliktir.
             *	- Farklı uygulama ile aynı isimde birden fazla yöntem oluşturma yeteneğidir.
             *	- Kodun okunabilirliğini ve yeniden kullanılabilirliğini artırır.
             *	- Birden çok adı hatırlamak yerine bir yöntem adını hatırlamak kolaydır.
             *	- Aşırı yüklenmiş yöntemler, programcılara farklı veri türleriyle benzer yöntemleri çağırma esnekliği verir.
             *
             * Metod Aşırı Yüklemesi Hakkında Hatırlanması Gereken 4 Kural
             * Bu durumda Aşırı Yükleme ve püf noktaları uygulayabiliriz
             *
             * 1- Parametre sayısı
             *		methodName(int, int)
             *		methodName(int, int, int)
             *
             * 2- Parametrelerin Veri Tipi
             *		methodName(int, int)
             *		methodName(int, float)
             *
             * 3- Veri Tipi Parametrelerinin Sırası
             *		methodName(int, float)
             *		methodName(float, int)
             *
             * 4- Geçersiz Durum - Yöntem Aşırı Yüklemesi Değil
             *		int methodName(int, int)
             *		float methodName(int, int)
			 */

            Console.WriteLine(Sum(5,4));
            Console.WriteLine(Sum(5,4,3));
            Console.WriteLine(Sum(5,4.4,3.3,2));


            #region Practice

            /*
             * Create a method called calcFeetAndInchesToCentimeters . It needs to have two
             * parameters. Feet is the first parameter, inches is the second parameter.
             * 
             * -> You should validate that the first parameter feet is >=0, and second
             * parameter inches is >=0 and <=12. Return -1 from the method if either of the
             * above is not true. -> If the parameters are valid, then calculate how many
             * centimeters comprise the feet and inches passed to this method and return
             * that value.
             * 
             * -> Create a second method of the same name but with only one parameter inches
             * is the parameter and validate it >=0, return -1 if it is not true. But if it
             * is valid, then calculate how many feet are in the inches.
             * 
             * -> Call the other overloaded method passing the correct feet and inches
             * calculated so that it can calculate correctly.
             * 
             * -> Hints : Use double for your number datatypes 1 inch = 2.54cm and 1 ft =12
             * inches
             *
             * ---------------------------------------------------------------------------------------------------------
             *
             * CalcFeetAndInchesToCentimeters adlı bir yöntem oluşturun. İki parametreye sahip olması gerekir.
             * "Feet" ilk parametre, "inç" ikinci parametredir.
             *
             * -> İlk parametre feet >=0 ve ikinci parametre inç >=0 ve <=12 olduğunu doğrulamanız gerekir.
             * Yukarıdakilerden herhangi biri doğru değilse, yöntemden -1 döndürün.
             *
             * -> Parametreler geçerliyse, bu yönteme geçen feet ve inch kaç santimetreden oluştuğunu hesaplayın ve bu değeri döndürün.
             *
             * -> Aynı ada sahip ikinci bir yöntem oluşturun, ancak yalnızca bir parametre ile parametredir ve doğrulayın >=0,
             * doğru değilse -1 döndürün. Ancak geçerliyse, inç cinsinden kaç fit olduğunu hesaplayın.
             *
             * -> Doğru şekilde hesaplayabilmesi için hesaplanan doğru fit ve inçleri geçen diğer aşırı yüklü yöntemi çağırın.
             *
             * -> İpuçları : Sayı veri türleri için double kullanın 1 inç = 2.54cm ve 1 ft =12 inç
             */
            CalcFeetAndInchesToCentimeters(100);
            CalcFeetAndInchesToCentimeters(6, 5);
            
            #endregion
        }
        public static int Sum(int a, int b) {
	        return a + b;
        }

        public static int Sum(int a, int b, int c) {
	        int result = a + b + c;
	        return result;
        }

        public static double Sum(double a, double b, double c, double d = 5) {
	        double result = a + b + c + d;
	        return result;
        }


        #region Practice Methods

        public static double CalcFeetAndInchesToCentimeters(double feet, double inches) { // method-1
	        if (feet < 0 || (inches < 0 || inches > 12)) { // inces 0-12
		        Console.WriteLine("Invalid feet or inches");
		        return -1;
	        }
	        double centimeters = (feet * 12) * 2.54 + (inches * 2.54);
	        Console.WriteLine(feet + " feet," + inches + " inches=" + centimeters + " centimeters");
	        return centimeters;
        }

        public static double CalcFeetAndInchesToCentimeters(double inches) { // method-2
	        if (inches < 0) {
		        Console.WriteLine("Invalid inches");
		        return -1;
	        }
	        double feet = (int) inches / 12;
	        double remainingInches = inches % 12;
	        Console.WriteLine(inches + " inches=" + feet + " feet and " + remainingInches + "inches");
	        return CalcFeetAndInchesToCentimeters(feet, remainingInches);
        }

        #endregion
    }
}