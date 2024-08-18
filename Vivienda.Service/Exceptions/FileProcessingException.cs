using System.IO;

namespace Vivienda.Service.Exceptions
{
    public class FileProcessingException : IOException
    {
        public string? FileName { get; }

        public FileProcessingException(string message, string fileName) : base(message)
        {
            FileName = fileName;
        }
    }
}
