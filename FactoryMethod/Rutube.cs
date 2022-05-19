using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class Rutube : VideoServiceBase
    {
        public Rutube(string serviceName) : base(serviceName)
        {

        }

        public override List<string> GetComments(string url)
        {
            PrintHeader();

            Login();

            base.VideoUrl = url;

            Console.WriteLine($"Выгрузка комментариев {ServiceName}");

            return new List<string> { $"{ServiceName} коммент 1", $"{ServiceName} коммент 2" };
        }

        protected override bool Login()
        {
            bool success = BoolRand();

            if (!success)
                throw new Exception($"Не удалось авторизоваться на {ServiceName}");

            return success;
        }
    }
}
