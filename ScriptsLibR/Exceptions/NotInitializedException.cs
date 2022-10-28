using System;

namespace ScriptsLibR.Exceptions
{
    public class NotInitializedException : Exception
    {
        public NotInitializedException() { }

        public NotInitializedException(object obj) : base($"The class '{obj.GetType()}' has not been initialized yet.") { }

        public NotInitializedException(object obj, Exception inner) : base($"The class '{obj.GetType()}' has not been initialized yet.", inner) { }
    }
}
