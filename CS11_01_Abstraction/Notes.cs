using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS11_01_Abstraction
{
    public class Notes
    {
        /*
             * Abstraction Class Notes
             * Abstraction: is concentrating on essential/important things and not worrying about details.
             * is concentrating on name of the action/behaviour, without thinking about implementation
             * 
             * Soyutlama: gerekli/önemli şeylere odaklanmak ve ayrıntılar hakkında endişelenmemektir. uygulamayı 
             * düşünmeden eylemin/davranışın adına odaklanmaktır.
             * 
             *	Vehicle
             *		- move
             *		- stop
             *		- turn
             *		- addfuel
             *		....
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	Abstraction can be done in 2 ways: Abstract classes, Interface
             *	Soyutlama 2 şekilde yapılabilir: Soyut sınıflar, Arayüz
             *	
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	Abstraction helps with "organizing the code", "reusing the code", "less duplicate code".
             *	
             *	Soyutlama, "kodu düzenleme", "kodu yeniden kullanma", "daha az yinelenen kod" 
             *	konularında yardımcı olur.
             *	
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	Can we instantiate abstract class?
             *		- No we can not create object from abstract class
             *		
             *  Soyut sınıfı Örnekleyebilir miyiz?
             *      - Hayır soyut sınıftan nesne oluşturamayız
             *      
             *		public abstract class Browser{}
             *		Browser browser = new Browser(); //Error
             *	
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	What is Abstract Method?
             *	Abstract Method Nedir?
             *	
             *		- is a method without body/implementation. Can be placed in abstract class or 
             *		interface
             *		
             *		- gövdesi/uygulaması olmayan bir yöntemdir. Soyut sınıfa veya arayüze yerleştirilebilir.
             *		
             *		public abstract class Browser{
             *		public abstract void navigate(String url);
             *		public abstract void displayWebpage();
             *		}
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	Where do we add implementation? 
             *	    - Is added in first concrete class
             *		- While adding implementation, all overriding rules should be followed.
             *		
             *	
             *	Uygulamayı nereye ekliyoruz?
             *		- Birinci yapıcı sınıfında eklenir.
             *		- Uygulama eklerken, tüm geçersiz kılma (overriding) kurallarına uyulmalıdır.
             *		
             *		public class Netscape extends Browser{
             *			public abstract void navigate(String url){
             *				//code
             *			}
             *			public abstract void displayWebpage(){
             *				//code
             *			}
             *		}
             *	
             *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *	
             *	Can we add non-abstract method in abstract class?
             *	    - Yes we can. Abstract class can have both abstract method and non-abstract method
			 * 
			 * Soyut sınıfa soyut olmayan bir yöntem ekleyebilir miyiz?
             *	    - Evet yapabiliriz. Soyut sınıf hem soyut yönteme hem de soyut olmayan yönteme sahip olabilir
             *	    
             *	    
             *	    public abstract class Browser{
             *	        public abstract void navigate(String url);
             *	        public abstract void displayWebpage();
             *	        public void close(){
             *	            //code
             *	        }
             *	    }
             *	    
             * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
             *   
             *   Is it mendatory for abstract class to have abstract method?
	         *       - No it is not. Abstract class can have 0 abstract method.
	         *       
	         *   Soyut(Abstract) sınıfın soyut(Abstract) metodu olması zorunlu mu? 
	         *		- Hayır zorunlu değil. Soyut sınıfın 0 soyut metodu olabilir.
	         *   
	         *       public abstract class Browser{
		     *           public void close(){
			 *               //code
		     *           }
	         *       }
	         * 
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
	         * 
	         * Can we add constructor in abstract class?
	         *      - Yes we can.
	         *   
	         * Soyut sınıfa yapıcı ekleyebilir miyiz?
	         *		- Evet
	         *		
	         *      public abstract class Browser {
	         *          public Browser() {
	         *              System.out.println("Creating a browser");
	         *          }
	         *      }
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
	         * 
	         * If we can not instantiate abstract class, how we can call the constructor?
	         *		- The constructor of abstract class can be called from a subclass using super keyword.
	         * 
	         * Soyut sınıfı başlatamazsak, yapıcıyı nasıl çağırabiliriz?
	         *		- Soyut sınıfın yapıcısı, super anahtar kelimesi kullanılarak bir alt sınıftan çağrılabilir.
	         * 
	         * public abstract class Browser {
	         *      public Browser() {
	         *          System.out.println("Creating a browser");
	         *          }
	         * } 
	         * 
	         * 
	         * public class Netscape extends Browser{
	         *      public Netscape(){
	         *          super();
	         *      }
	         * }
	         * 
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
	         * 
	         * Can you add instance or static variables into abstract class?
	         *		- Yes we can have instance variables in abstract class
	         * 
	         * public abstract class Browser {
	         *      String name;
	         *      static int id;
	         *      
	         *      public Browser() {
	         *          System.out.println("Creating a browser");
	         *      }
	         * }
	         * 
	         * - Variables can not be abstract.
	         * - Değişkenler abstract olamaz.
	         * 
	         *        abstract int id; //Error
	         *        
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
	         * 
	         * Can we add instance or static init block
	         *      - Yes we can 
	         *      
	         * Örnek veya statik init bloğu ekleyebilir miyiz?
	         *		- Evet
	         * 
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
	         * 
	         * Can an abstract class extend another abstract class?
	         *		- Yes it can 
	         *		
	         *		public abstract class A{}
	         *		public abstract class B extends A{}
	         * -----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
			 *
			 *	Can an abstract class extend another non-abstract class?
			 *		- Yes it can 
		     *
		     * Soyut bir sınıf başka bir soyut sınıfı genişletebilir mi?
		     *		- Evet yapabilir
		     *		
			 *		public class A{}
			 *		public abstract class B extends A{}
		     *
			 *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
		     *
			 *	Can a class extends multiple abstract classes?
			 *		- No it can not
			 *		
			 *	Bir sınıf birden çok soyut sınıfı genişletebilir mi?
			 *		- Hayır bu olamaz	
			 *	
		     *
			 *		public abstract class A{}
			 *		public abstract class B{}
		     *
			 *		public class C extends A,B{} //Error
		     * 
			 *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
		     *
			 *	Can we add static method into abstract class?
			 *		- yes we can 
			 *		
			 * Statik metodu soyut sınıfa ekleyebilir miyiz?
			 *		- Evet yapabiliriz
		     *
			 *			public abstract class A{
		     *
	    	 *				public static void methodX(){
		     *
	    	 *				}
			 *			}
		     *
			 *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
			 *
			 *	Can a method be abstract and final in abstract class?
			 *		- No it can not 
		     *
		     * Soyut sınıf içinde bir yöntem soyut ve final olabilir mi?
			 *		- Hayır bu olamaz
			 *		
			 *		
			 *		public abstract class Browser{
			 *			public abstract final void navigate(String url); //Error
			 *			public abstract void displayWebpage();
			 *		}
		     *
		     *
			 *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
		     *
			 *	Can abstract method be protected, private, and default?
			 *	
			 *	Soyut yöntem korumalı, özel ve varsayılan olabilir mi?
			 *	
			 *		- private: no
			 *		- default: yes 
			 *		- protected: yes
		     *
			 *	-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----o-----
		     *
			 *	When an abstract class extends another abstract class, does it require to override/implement 
			 *	abstract methods from parent?
			 *		- No it does not require
			 *		- First concrete sub class is required to implement all abstract methods
			 *		
			 * Bir soyut sınıf başka bir soyut sınıfı genişlettiğinde, ebeveynden soyut yöntemleri geçersiz 
			 * kılmak/uygulamak gerekir mi?
			 *		- Hayır gerektirmez
			 *		- Tüm soyut yöntemleri uygulamak için ilk somut alt sınıf gereklidir
			 */
    }
}
