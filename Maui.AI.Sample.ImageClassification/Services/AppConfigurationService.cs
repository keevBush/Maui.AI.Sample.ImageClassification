using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.AI.Sample.ImageClassification.Services
{
    public interface IAppConfigurationService
    {
        string PathModel { get; }
        Task SetPathModel(string pathModel);
    }
    internal class AppConfigurationService : IAppConfigurationService
    {
        public string PathModel => throw new NotImplementedException();

        public Task SetPathModel(string pathModel)
        {
            throw new NotImplementedException();
        }
    }
}
