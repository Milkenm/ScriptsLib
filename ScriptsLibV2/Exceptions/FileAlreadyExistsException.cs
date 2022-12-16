using System;

namespace ScriptsLibV2.Exceptions
{
    public class FileAlreadyExistsException : Exception
    {
        public FileAlreadyExistsException() { }

        public FileAlreadyExistsException(string filePath) : base($"The file '{filePath}' already exists.") { }

        public FileAlreadyExistsException(string filePath, Exception inner) : base($"The file '{filePath}' already exists.", inner) { }
    }
}
