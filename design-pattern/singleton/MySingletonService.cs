using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    /// <summary>
    /// Implement Singleton: Eager initialization
    /// </summary>
    public class MySingletonService
    {
        private static int creationCount = 0;

        //PRIVATE ONLY 1 INSTANCE OF CLASS 
        private static readonly MySingletonService _mySingletonServiceInstance = new MySingletonService();

        //PRIVATE CONSTRUCTOR
        private MySingletonService()
        {
            creationCount++;
            Console.WriteLine("Counter Value " + creationCount.ToString());
        }

        //PUBLIC STATIC METHOD RETURN INSTANCE 
        public static  MySingletonService GetInstance() => _mySingletonServiceInstance;

        //DISPLAY
        public int GetCreationCount() => creationCount;

        public void ViewCreationCount()
        {
            Console.WriteLine($"Count Instance {creationCount}");
            Console.ReadKey();
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    /// <summary>
    /// Implement Singleton: Lazy initialization
    /// </summary>
    public class MySingletonService1
    {
        private static int creationCount1 = 0;

        //PRIVATE ONLY 1 INSTANCE OF CLASS 
        //private static MySingletonService1 _mySingletonServiceInstance1 = new MySingletonService1(); ??? WHY: CALL GETINSTANCE THEN INIT INSTACNE
        private static MySingletonService1 _mySingletonServiceInstance1 = null;

        //PRIVATE CONSTRUCTOR
        private MySingletonService1()
        {
            creationCount1++;
            Console.WriteLine("Counter Value " + creationCount1.ToString());

        }

        //PUBLIC STATIC METHOD RETURN INSTANCE 
        public static MySingletonService1 GetInstance
        {
            get
            {
                if (_mySingletonServiceInstance1 == null)
                {
                    _mySingletonServiceInstance1 = new MySingletonService1();
                }
                return _mySingletonServiceInstance1;

            }
        }

        public int GetCreationCount() => creationCount1;

        public void ViewCreationCount()
        {
            Console.WriteLine($"Count Instance {creationCount1}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
