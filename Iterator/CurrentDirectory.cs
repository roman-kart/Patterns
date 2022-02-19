using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class CurrentDirectory
    {
        public IEnumerable<string> FilesNames(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                yield return file;
            }
        }
    }
}
