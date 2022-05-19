using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class YouTube : VideoServiceBase
    {
       
        public YouTube(string serviceName) : base(serviceName)
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
            const int LEN = 4;
            bool success;
            int authCode;

            Console.WriteLine($"Введите логин для {ServiceName}");
            base.UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(base.UserName))
                throw new ArgumentException($"Логин не может быть пустым");

            Console.WriteLine($"Введите Пароль для {ServiceName}");
            base.Password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(base.Password))
                throw new ArgumentException($"Пароль не может быть пустым");

            Console.WriteLine($"Введите {LEN}-х значный цифровой код из СМС сообщения");
            
            string codeInput = Console.ReadLine();
            
            if(int.TryParse(codeInput, out authCode) && authCode > 0 && codeInput.Length == LEN)
            {
                success = BoolRand();

                if (!success)
                    throw new Exception($"Не удалось авторизоваться на {ServiceName}");
            }
            else
            {
                throw new Exception("Неверный код авторизации");
            }

            return success;
        }
    }
}
