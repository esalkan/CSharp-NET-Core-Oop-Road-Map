namespace CS01_42_Loops_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DO-WHILE
			 * do...while loop repeatedly executes same set of statements while(condition) is true.
             * do...while döngüsü, while(condition) true olduğunda aynı deyim kümesini tekrar tekrar yürütür.
			 * 
			 * The statement is executed once initially then Condition is cheked at loop end.
             * İfade başlangıçta bir kez yürütülür, ardından döngü sonunda Koşul kontrol edilir.
			 * 
			 * Code in Loop body will execute at least once.
             * Döngü gövdesindeki kod en az bir kez yürütülür.
			 * 
			 * 
			 */
            
            #region Syntax & Basic Example | Syntax & Basit bir örnek
            Console.WriteLine("-----> Syntax & Basic Example | Syntax & Basit bir örnek <-----");
            int i = 20;
            do
            {
	            Console.WriteLine(i);
            } while (i <= 10);
            #endregion

            #region Example 01 | Örnek 01
            /*
             * Kullanıcıyı do while içerisine alın ve kullanıcı adı ve parolasını sorun.
             *		Kullanıcı adı	: Demo
             *		Şifre			: Demo
             * Eğer kullanıcı bu bilgileri doğru girerse döngüden çıkın ve başarılı yazın.
             * Eğer kullanıcı bu bilgileri doğru giremezse ilgili değerleri sormaya devam edin.
             *
             * Get the user in do while and ask for username and password.
             *		Username	: Demo
             *		Password	: Demo
             * If the user enters this information correctly, exit the loop and write successfully.
             * If the user cannot enter this information correctly, keep asking for the relevant values.
             */

            string userName, password;
            string dbUserName = "Demo", dbpassword = "Demo";
            
            bool flag = true;
            
            do
            {
	            Console.WriteLine("Enter your Username | Kullanıcı adınızı girin :");
	            userName = Console.ReadLine();
	            Console.WriteLine("Enter your Password | Kullanıcı Şifrenizi girin :");
	            password = Console.ReadLine();

	            if (userName == dbUserName && password == dbpassword)
	            {
		            flag = false;
		            Console.WriteLine("Login Success! | Giriş Başarılı!");
	            }
	            else
	            {
		            if (userName != dbUserName & password != dbpassword)
		            {
			            Console.WriteLine("Wrong username & password! | Yanlış Kullanıcı Adı ve Şifre!");
			            
		            } else if (password != dbpassword)
		            {
			            Console.WriteLine("Wrong password! | Yanlış Şifre!");
		            }
		            else if (userName != dbUserName)
		            {
			            Console.WriteLine("Wrong Username | Yanlış Kullanıcı Adı!");
		            }
	            }

            } while (flag);

            #endregion

            #region Example 02 | Örnek 02

            /*
		     * Kullanıcıdan 1 ile x arasında bir sayı girmesini isteyin.
		     * Daha sonra sistem kullanıcının girmiş olduğu 1 ile x değerleri arasında bir sayı tahmini yapsın.
		     * Daha sonra kullanıcı sistemin tahmin etmiş olduğu sayıyı bulmaya çalışsın.
		     * Bulamaz ise yeniden yeniden sorsun.
		     * Ne zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin
		     *
		     * Ask the user to enter a number between 1 and x.
		     * Then the system will make a number prediction between 1 and x values entered by the user.
		     * Then the user tries to find the number that the system predicted.
		     * If you can't find it, ask again.
		     * Whenever the user finds the relevant value, say you tried Y times and you got the result.
		     */

            bool flag1 = true;
            Console.WriteLine("\nSystem will generate a random number between 1 - X and you will try to guess the number!");
            Console.WriteLine("Sistem 1 - X arasında rastgele bir sayı üretecek ve siz sayıyı tahmin etmeye çalışacaksınız!");
            Console.WriteLine("Enter a number | Bir sayı girin :");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, userInput);
            int counter = 0;
            int userGuess;
            Console.WriteLine("Make your first guess! | İlk tahminizi yapın!");
            do
            {
	            counter++;
	            userGuess = Convert.ToInt32(Console.ReadLine());
	            if (userGuess == randomNumber)
	            {
		            flag1 = false;
		            Console.WriteLine($"After {counter} try! Congrats!!! | {counter} Deneme sonrası, Tebrikler! ");
	            }
	            else
	            {
		            Console.WriteLine("Try again! | Yeniden deneyin!");
	            }
            } while (flag1);
            #endregion
        }
    }
}