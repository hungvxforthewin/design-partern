using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class MySingletonService
    {
        private static int creationCount = 0;

        //PRIVATE ONLY 1 INSTANCE OF CLASS 
        private static readonly MySingletonService _mySingletonServiceInstance = new MySingletonService();

        //PRIVATE CONSTRUCTOR
        private MySingletonService()
        {
            creationCount++;
        }

        //PUBLIC STATIC METHOD RETURN INSTANCE 
        public static MySingletonService GetInstance() => _mySingletonServiceInstance;

        public int GetCreationCount() => creationCount;

        public void ViewCreationCount()
        {
            Console.WriteLine($"Count Instance {creationCount}");
        }
    }
}
