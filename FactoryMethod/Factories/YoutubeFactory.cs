using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    internal class YoutubeFactory : VideoServiceFactory
    {
        public YoutubeFactory()
        {
            base.VideoServiceName = "YouTube";
            this.Domain = "youtube.com";
        }

        public override IVideoService GetVideoService()
        {
            return new YouTube(base.VideoServiceName);
        }
    }
}
