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
    public static class Unzipper
    {
        public static async Task ExtractList(IEnumerable<string> files)
        {
            List<Task> tasks = new List<Task>();

            foreach (var file in files)
            {
                tasks.Add(Task.Factory.StartNew(() => Extractor(file)));
                //Extractor(file);
            }

            await Task.WhenAll(tasks);

            var ds = tasks;
        }

        public static string Extractor(string path)
        {
            FileInfo archiveFile = new FileInfo(path);

            string outFileName = path.Replace(".bz2", "");

            using (FileStream fileToDecompressAsStream = archiveFile.OpenRead())
            {
                using (FileStream decompressedStream = File.Create(outFileName))
                {
                    try
                    {
                        BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }

            return outFileName;
        }

        public static Task<string> ExtractAsync(string path)
        {
            return Task.Run(() => Extractor(path));
        }
    }
}
