using System;

namespace Day16
{
    public class Abonents
    {
        static void AppendInvokations(PostOffice office)
        {
            var lambdaForPosting = new PostSended(
                (postData, abonent) =>
                {
                    if (postData == -1)
                    {
                        Console.WriteLine("Отправил -1");
                        Environment.Exit(0);
                    }
                    else
                        Console.WriteLine($"Сообщение {postData} абоненту  {abonent}");
                }
            );
            office.Sended1 += lambdaForPosting;
            office.Sended2 += lambdaForPosting;
            office.Sended3 += lambdaForPosting;
        }

        public static void Post1(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 1 отправил \n");
        }
        public static void Post2(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 2 отправил\n");
        }
        public static void Post3(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 3 отправил\n");
        }
    }
}