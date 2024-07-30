using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.AI.Sample.ImageClassification.Utils.AI
{
    internal class ImagePrediction : ImageData
    {
        public float[]? _score;

        public string? _predictedLabelValue;
    }
}
