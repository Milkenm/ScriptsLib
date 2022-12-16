using System;

namespace ScriptsLibV2.Exceptions
{
    public class DatabaseFileNotFoundException : Exception
    {
        public DatabaseFileNotFoundException() { }

        public DatabaseFileNotFoundException(string databasePath) : base($"The database file '{databasePath}' does not exist.") { }

        public DatabaseFileNotFoundException(string databasePath, Exception inner) : base($"The database file '{databasePath}' does not exist.", inner) { }
    }
}
