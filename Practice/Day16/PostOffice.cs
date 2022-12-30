using System;

namespace Day16
{
    public delegate void PostSended(int post, int abonent);
    public class PostOffice
    {
        public event PostSended Sended1;
        public event PostSended Sended2;
        public event PostSended Sended3;

        public void SendMessage(int abonent, int post)
        {
            switch (abonent)
            {
                case 1:
                {
                    if (Sended1 != null)
                    {
                        Sended1(post, 1);
                        Console.WriteLine("Событие 1 выполнено");
                    }
                    break;
                }
                case 2:
                {
                    if (Sended2 != null)
                    {
                        Sended2(post, 2);
                        Console.WriteLine("Событие 2 выполнено");
                    }
                    break;
                }
                case 3:
                {
                    if (Sended3 != null)
                    {
                        Sended3(post, 3);
                        Console.WriteLine("Событие 3 выполнено");
                    }
                    break;
                }
                default:
                {
                    break;
                }
            }
            Sended2 = null;
            Sended3 = null;
        }
    }
}