using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    internal abstract class VideoServiceFactory
    {
        public string VideoServiceName;

        public string Domain;
        public abstract IVideoService GetVideoService();
    }
}
