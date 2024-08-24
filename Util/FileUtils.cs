using System.Collections.Generic;
using System.IO;

namespace Util
{
    public class FileUtils
    {
        public static Dictionary<string, string> ReadHashMap(Stream stream)
        {
            var result = new Dictionary<string, string>();
            var streamReader = new StreamReader(stream);
            var line = streamReader.ReadLine();
            while (line != null)
            {
                var list = line.Split(" ");
                if (list.Length == 2)
                {
                    result[list[0]] = list[1];
                }

                line = streamReader.ReadLine();
            }

            return result;
        }

    }
}