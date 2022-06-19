using System;

namespace SingletonCalisam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
     class Singleton
    {
        private static Singleton singleton;
        private Singleton()
        {
            //sınıfımızı new yapmamızı engelliyor
        }
        public static Singleton olustur()
        {
            if (singleton==null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}
