using System;

namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Display();
            
            //KHỞI TẠO INSTANCE 1
            MySingletonService serviceInstance1 = MySingletonService.GetInstance();
            //Console.WriteLine(serviceInstance1.GetCreationCount());
            serviceInstance1.ViewCreationCount();
            
            //KHỞI TẠO INSTANCE 2
            MySingletonService serviceInstance2 = MySingletonService.GetInstance();
            //Console.WriteLine(serviceInstance2.GetCreationCount());
            serviceInstance2.ViewCreationCount();

            //KIỂM TRA CÁC INSTANCE ĐƯỢC TẠO
            Console.WriteLine(serviceInstance1 == serviceInstance2);
        }

        public static void Display() => Console.WriteLine("dotNET 5");
    }
}
