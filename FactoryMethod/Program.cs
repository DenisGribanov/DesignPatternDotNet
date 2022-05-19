using FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Program
    {
        private static readonly List<VideoServiceFactory> factories = new List<VideoServiceFactory>
        {
                new YoutubeFactory(),
                new RutubeFactory()
        };

        public static void Main(string[] args)
        {
            var domains = factories.Select(x => x.Domain).ToList();

            Console.WriteLine($"Выгрузка комментариев под видео для сервисов : {string.Join(',', domains)}");

            Console.WriteLine("Ввелите ссыку");

            string url = Console.ReadLine();

            var service = factories.Where(x => url.Contains(x.Domain)).FirstOrDefault();

            if(service == null)
            {
                Console.WriteLine("Данный видеосервис не поддерживается");
                return;
            }

            service.GetVideoService().GetComments(url);
        }
    }
}
