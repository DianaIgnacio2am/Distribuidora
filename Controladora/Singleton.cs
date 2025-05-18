using Modelo;

namespace Controladora
{
    public class Singleton<T> 
        where T : new() 
    {
        // Singleton thread-safe por si quiero usar "Parallel"
        private static T instance = new T();
        
        public static T Instance
        {
            get
            {                
                return instance;
            }   
        }

    }
}