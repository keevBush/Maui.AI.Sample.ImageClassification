using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Model.Generator.Utils
{
    internal class ImageNetDataProbability :  ImageNetData
    {
        public string PredictedLabel;
        public float Probability { get; set; }
    }
}
