using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal abstract class VideoServiceBase : IVideoService
    {
        public string ServiceName { get; }

        public string UserName { get; protected set; }

        public string Password { get; protected set; }

        public string VideoUrl { get; protected set; }

        public VideoServiceBase(string serviceName)
        {
            ServiceName = serviceName;
        }

        public abstract List<string> GetComments(string url);

        protected abstract bool Login();

        protected bool BoolRand()
        {
            Random random = new Random();
            const int MIN = 0;
            const int MAX = 2;

            return random.Next(MIN, MAX) > MIN;
        }

        protected void PrintHeader()
        {
            Console.WriteLine(ServiceName);
        }
    }
}
