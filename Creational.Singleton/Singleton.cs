/**
 * Example of lazy, thread-safe Singleton design pattern.
 * When we need to ensures that only one instance of a particular class is going to be created. 
 * We have to provide a simple global access to that instance for the entire application.
 */
using System;

namespace Creational.Singleton
{
    //sealed required.
    //Ensure that the class cannot be inherited.
    public sealed class Singleton
    {
        //Thread-safe initialization.
        //https://docs.microsoft.com/en-us/dotnet/framework/performance/lazy-initialization?redirectedfrom=MSDN
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return _instance.Value; } }

        //private and parameterless constructor required.
        //It is not allowed the class to be instantiated from outside the class.
        private Singleton() { }
    }
}
