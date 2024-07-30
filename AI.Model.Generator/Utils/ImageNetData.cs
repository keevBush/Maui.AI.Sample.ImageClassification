using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Model.Generator.Utils
{
    internal class ImageNetData
    {
        [LoadColumn(0)]
        public string ImagePath;

        [LoadColumn(1)]
        public string Label;

        public static IEnumerable<ImageNetData> ReadFromCsv(string file, string folder)
        {
            return File.ReadAllLines(file)
             .Select(x => x.Split('\t'))
             .Select(x => new ImageNetData { ImagePath = Path.Combine(folder, x[0]), Label = x[1] });
        }
    }
}
