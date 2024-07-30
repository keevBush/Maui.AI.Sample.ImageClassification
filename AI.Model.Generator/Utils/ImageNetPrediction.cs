using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Model.Generator.Utils
{
    internal class ImageNetPrediction
    {
        [ColumnName("softmax2")]
        public float[] PredictedLabels;
    }
}
