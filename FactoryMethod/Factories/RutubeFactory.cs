using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    internal class RutubeFactory : VideoServiceFactory
    {
        public RutubeFactory()
        {
            base.VideoServiceName = "Rutube";
            this.Domain = "rutube.ru";
        }
        public override IVideoService GetVideoService()
        {
            return new Rutube(base.VideoServiceName);
        }
    }
}
