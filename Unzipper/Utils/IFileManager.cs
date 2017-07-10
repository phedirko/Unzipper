using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unzipper.Utils
{
    public interface IFileManager
    {
        void OpenFile(string path);

        IEnumerable<string> DirSearch(string path);
    }
}
