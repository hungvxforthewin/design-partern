using System;
using System.Threading;
using System.Threading.Tasks;

namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Display();

            //Singleton_Not_Synchronized();
            //MySingletonService_Mutil_Thread();
            MySingletonService_Mutil_Task();

            // Parallel.Invoke(
            //    () =>
            //    PrintTeacherDetails(),
            //    () =>
            //    PrintStudentdetails()
            //);
        }

        public static void Display() => Console.WriteLine("dotNET 5");

        public static void Singleton_Not_Synchronized()
        {
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

        public static void MySingletonService_Mutil_Thread()
        {
            Thread t1 = new Thread(() =>
            {
                //KHỞI TẠO INSTANCE 1
                MySingletonService serviceInstance1 = MySingletonService.GetInstance();
                //Console.WriteLine(serviceInstance1.GetCreationCount());
                serviceInstance1.ViewCreationCount();
            });
            Thread t2 = new Thread(() =>
            {
                //KHỞI TẠO INSTANCE 2
                MySingletonService serviceInstance2 = MySingletonService.GetInstance();
                //Console.WriteLine(serviceInstance2.GetCreationCount());
                serviceInstance2.ViewCreationCount();
            });
            t1.Start();
            t2.Start();


            //KIỂM TRA CÁC INSTANCE ĐƯỢC TẠO
            //Console.WriteLine(serviceInstance1 == serviceInstance2);
        }

        public static void MySingletonService_Mutil_Task()
        {
            Parallel.Invoke(
               () =>
               PrintTeacherDetails(),
               () =>
               PrintStudentdetails()
           );


            //KIỂM TRA CÁC INSTANCE ĐƯỢC TẠO
            //Console.WriteLine(serviceInstance1 == serviceInstance2);
        }
        private static void PrintTeacherDetails()
        {
            MySingletonService1 serviceInstance1 = MySingletonService1.GetInstance;
            serviceInstance1.PrintDetails("FROM A");
        }
        private static void PrintStudentdetails()
        {
            MySingletonService1 serviceInstance2 = MySingletonService1.GetInstance;
            serviceInstance2.PrintDetails("FROM B");
        }
    }
}


//namespace singleton
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Parallel.Invoke(
//                () => PrintTeacherDetails(),
//                () => PrintStudentdetails()
//                );
//            Console.ReadLine();
//        }

//        private static void PrintTeacherDetails()
//        {
//            Singleton fromTeacher = Singleton.GetInstance;
//            fromTeacher.PrintDetails("From Teacher");
//        }

//        private static void PrintStudentdetails()
//        {
//            Singleton fromStudent = Singleton.GetInstance;
//            fromStudent.PrintDetails("From Student");
//        }
//    }
//}

//namespace singleton
//{
//    public sealed class Singleton
//    {
//        private static int counter = 0;
//        private static Singleton instance = null;
//        public static Singleton GetInstance
//        {
//            get
//            {
//                if (instance == null)
//                    instance = new Singleton();
//                return instance;
//            }
//        }
//        private Singleton()
//        {
//            counter++;
//            Console.WriteLine("Counter Value " + counter.ToString());
//        }
//        public void PrintDetails(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//}