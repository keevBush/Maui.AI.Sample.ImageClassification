using Maui.AI.Sample.ImageClassification.Utils.AI;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.AI.Sample.ImageClassification.Services
{
    public interface IImageClassificationService
    {
        Task<(string, float)> ClassifyImageAsync(Stream image);
    }
    internal class ImageClassificationService : IImageClassificationService
    {
        private readonly MLContext _mLContext;
        private readonly IAppConfigurationService _appConfigurationService;
        public ImageClassificationService(MLContext mLContext, IAppConfigurationService appConfigurationService)
        {
            _mLContext = mLContext;
            _appConfigurationService = appConfigurationService;
            //var predictor = _mLContext.Model.CreatePredictionEngine<ImageData, ImagePrediction>()
        }
        public Task<(string, float)> ClassifyImageAsync(Stream image)
        {
            throw new NotImplementedException();
        }
    }
}
