using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal interface IVideoService
    {
        string ServiceName { get; }

        string UserName { get; }

        string Password { get; }

        string VideoUrl { get; }

        List<string> GetComments(string url);

    }
}
