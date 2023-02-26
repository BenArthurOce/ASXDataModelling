using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class DocumentUploadHistoryModel
    {
        public Guid Id { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public DateTime DateTimeUploaded { get; set; }

        public long FileSizeBytes { get; set; }

        public long RowsInFile { get; set; }


        public DocumentUploadHistoryModel(string filePath, string fileName, DateTime dateTimeUploaded, long fileSizeBytes, long rowsInFile)
        {
            FilePath = filePath;
            FileName = fileName;
            DateTimeUploaded = dateTimeUploaded;
            FileSizeBytes = fileSizeBytes;
            RowsInFile = rowsInFile;
        }
    }
}
