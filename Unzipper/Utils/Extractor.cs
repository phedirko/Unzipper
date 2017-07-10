using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.BZip2;

namespace Unzipper.Utils
{
    public class Extractor : IExtractor
    {
        public Task<string> ExtractAsync(string path)
        {
            return Task.Run(() => Extract(path));
        }

        private string Extract(string path)
        {
            FileInfo archiveFile = new FileInfo(path);

            string outFileName = path.Replace(".bz2", "");

            if (File.Exists(outFileName))
            {
                outFileName = outFileName.Replace(".json", DateTime.Now.Ticks + ".json");
            }


            using (FileStream fileToDecompressAsStream = archiveFile.OpenRead())
            {
                FileStream decompressedStream = File.Create(outFileName);

                try
                {
                    BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

            }

            return outFileName;
        }
    }
}
