using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unzipper.Utils
{
    public interface IExtractor
    {
        Task<string> ExtractAsync(string path, bool deleteFiles);
    }
}
