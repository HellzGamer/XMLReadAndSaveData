using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewXmlWork.Logic
{
    public class FileSearchHelper
    {
        public string FilePath { get; set; }
        public FileSearchHelper(string filepath)
        {
            FilePath = filepath;
        }
        public string[] AllFilesFromFolder()
        {
            return Directory.GetFiles(FilePath);
        }
    }
}
