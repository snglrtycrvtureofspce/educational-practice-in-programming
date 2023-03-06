using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day23
{
    public static class ColoredConsole
    {
        public static void WriteLine(ConsoleColor color, string format, params object[] list)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(format, list);
            Console.ResetColor();
        }

        public static void Write(ConsoleColor color, string format, params object[] list)
        {
            Console.ForegroundColor = color;
            Console.Write(format, list);
            Console.ResetColor();
        }

        //public static void RedCallback(object o)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Red");
        //    Console.ResetColor();
        //}

        //public static void GreenCallback(object o)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Green");
        //    Console.ResetColor();
        //}
        // проблема скрыта в том, что два таймера работают асинхронно и конкурируют за доступ к консоли, что может приводить к непредсказуемому выводу цветов текста
        // решение проблемы с использованием монитора
        static object consoleLock = new object();

        public static void RedCallback(object o)
        {
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                Console.ResetColor();
            }
        }

        public static void GreenCallback(object o)
        {
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                Console.ResetColor();
            }
        }
    }

    public static class ColoredConsole3
    {
        private static readonly object _lockObject = new object();

        public static void Write(string message, ConsoleColor color)
        {
            lock (_lockObject)
            {
                Console.ForegroundColor = color;
                Console.Write(message);
                Console.ResetColor();
            }
        }

        public static void WriteLine(string message, ConsoleColor color)
        {
            lock (_lockObject)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
    internal class Program
    {
        public static int Million100 { get; set; } // 2.1 - 2.2
        private static readonly object _lockObject = new object(); // 1.4
        private static int _threadCount = 0; // 1.4
        private static Mutex _mutex = new Mutex();
        private static Semaphore _sem = new Semaphore(2, 2); // ограничение в 2 потока
        delegate string DictionaryLookupDelegate(string word);
        private static /*async Task*/ void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1: // 1.1
                {
                    ColoredConsole.WriteLine(ConsoleColor.White, "Это белая строка.");
                    ColoredConsole.WriteLine(ConsoleColor.Green, "Это зелёная строка.");
                    ColoredConsole.WriteLine(ConsoleColor.DarkMagenta, "Это тёмно-пурпурная строка.");
                    ColoredConsole.Write(ConsoleColor.Cyan, "Это голубая строка.");
                    ColoredConsole.Write(ConsoleColor.Red, "Это красная строка. ");
                    ColoredConsole.Write(ConsoleColor.Gray, "Это серая строка.");
                    break;
                }
                case 2: // 1.2
                {
                    Timer redTimer = new Timer(ColoredConsole.RedCallback, null, 0, 200);

                    Timer greenTimer = new Timer(ColoredConsole.GreenCallback, null, 0, 200);

                    Thread.Sleep(5000);
                    break;
                }
                case 3: // 1.3
                {
                    Thread t1 = new Thread(() => ColoredConsole3.WriteLine("Поток 1", ConsoleColor.Red));
                    Thread t2 = new Thread(() => ColoredConsole3.WriteLine("Поток 2", ConsoleColor.Green));
                    Thread t3 = new Thread(() => ColoredConsole3.WriteLine("Поток 3", ConsoleColor.Blue));

                    t1.Start();
                    t2.Start();
                    t3.Start();

                    t1.Join();
                    t2.Join();
                    t3.Join();
                    break;
                }
                case 4: // 1.4
                {
                    Console.WriteLine("Нажмите любую клавишу для выхода.");

                    TimerCallback callback = new TimerCallback(OnTimerElapsed);
                        
                    Timer timer = new Timer(callback, ConsoleColor.Yellow, 0, 1000);
                        
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(".");
                        Thread.Sleep(50);
                    }

                    timer.Dispose();
                    break;
                }
                case 5: // 2.1
                {
                    const int NUM_THREADS = 20;
                    const int NUM_ITERATIONS = 5_000_000;

                    Thread[] threads = new Thread[NUM_THREADS];

                    for (int i = 0; i < NUM_THREADS; i++)
                    {
                        threads[i] = new Thread(() =>
                        {
                            for (int j = 0; j < NUM_ITERATIONS; j++)
                            {
                                lock (typeof(Program))
                                {
                                    Million100++;
                                }
                            }
                        });
                        threads[i].Start();
                    }

                    while (true)
                    {
                        Console.WriteLine($"Million100: {Million100}");
                        Thread.Sleep(50);
                    }

                    break;
                }
                case 6: // 2.2
                {
                    const int threadsCount = 20;
                    const int iterationsCount = 5000000;

                    Thread[] threads = new Thread[threadsCount];
                    for (int i = 0; i < threadsCount; i++)
                    {
                        threads[i] = new Thread(() =>
                        {
                            for (int j = 0; j < iterationsCount; j++)
                            {
                                lock (typeof(Program))
                                {
                                    Million100++;
                                }
                            }
                        });
                        threads[i].Start();
                    }

                    while (true)
                    {
                        lock (typeof(Program))
                        {
                            if (Million100 == threadsCount * iterationsCount)
                            {
                                Console.WriteLine(Million100);
                                break;
                            }
                        }

                        Thread.Sleep(50);
                    }
                    break;
                }
                case 7: // 2.3
                {
                    AutoResetEvent[] events = new AutoResetEvent[3];

                    for (int i = 0; i < 3; i++)
                    {
                        events[i] = new AutoResetEvent(false);
                        Thread thread = new Thread(new ParameterizedThreadStart(DoWork))
                        {
                            Name = $"Поток {i + 1}"
                        };
                        thread.Start(events[i]);
                    }

                    WaitHandle.WaitAll(events);

                    Console.WriteLine("Все потоки завершили свою работу.");
                    break;
                }
                case 8:
                {
                    Thread thread1 = new Thread(new ThreadStart(ThreadMethod));
                    Thread thread2 = new Thread(new ThreadStart(ThreadMethod));
                    Thread thread3 = new Thread(new ThreadStart(ThreadMethod));
        
                    thread1.Name = "Поток 1";
                    thread2.Name = "Поток 2";
                    thread3.Name = "Поток 3";
        
                    thread1.Start();
                    thread2.Start();
                    thread3.Start();
        
                    thread1.Join();
                    thread2.Join();
                    thread3.Join();
        
                    Console.WriteLine("Все потоки завершили свою работу.");
                    break;
                }
                case 9:
                {
                    Thread[] threads = new Thread[3];

                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i] = new Thread(DoWork2)
                        {
                            Name = $"Поток {i + 1}"
                        };
                        threads[i].Start();
                    }

                    foreach (Thread thread in threads)
                    {
                        thread.Join();
                    }

                    Console.WriteLine("Работа всех потоков завершена.");
                    break;
                }
                case 10:
                {
                    Task task1 = Task.Factory.StartNew(DoWork3);
                    Task task2 = Task.Factory.StartNew(DoWork3);
                    Task task3 = Task.Factory.StartNew(DoWork3);

                    Task.WaitAll(task1, task2, task3);

                    Console.WriteLine("Все задачи завершились.");
                    break;
                }
                case 11:
                {
                    var first = Task.Factory.StartNew(() => DoWork4(1))
                        .ContinueWith(previous => DoWork4(2))
                        .ContinueWith(previous => DoWork4(3));

                    first.Wait();
                    break;
                }
                case 12:
                {
                    DictionaryLookupDelegate lookup = LookupWord;

                    string word = "К";
                    Console.WriteLine($"Глядя в '{word}' в словаре...");
                    string article = lookup(word);
                    Console.WriteLine($"Найдена статья:\n{article}");

                    Thread thread = new Thread(Animate);
                    thread.Start();
                        
                    Thread.Sleep(100);
                        
                    Console.WriteLine("Выполнение другой работы...");

                    thread.Join();
                    break;
                }
                case 13:
                {
                    DictionaryLookupDelegate lookup = LookupWord2;

                    string word = "К";
                    Console.WriteLine($"Поиск в '{word}' в словаре асинхронности...");

                    IAsyncResult result = lookup.BeginInvoke(word, null, null);
                        
                    Thread thread = new Thread(Animate2);
                    thread.Start(result);
                        
                    while (!result.IsCompleted)
                    {
                        Console.Write(".");
                        Thread.Sleep(50);
                    }
                    
                    thread.Abort();
                        
                    string article = lookup.EndInvoke(result);
                    Console.WriteLine($"Найдена статья:\n{article}");
                    break;
                }
                case 14:
                {
                    //string word = "КБИП";
                    //string article = await LookupWordAsync(word);

                    //Console.WriteLine($"\nНайдена статья:\n{article}");
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }
        static async Task<string> LookupWordAsync(string word)
        {
            Console.WriteLine($"Поиск в '{word}' в словаре асинхронности...");

            return await Task.Run(() => LookupWord3(word));
        }

        static string LookupWord3(string word)
        {
            Thread.Sleep(1000);
            
            return $"Статья для '{word}':\nСловарь КБИП";
        }
        static string LookupWord2(string word)
        {
            Thread.Sleep(1000);
            
            return $"Статья для '{word}':\nСловарь КБИП";
        }

        static void Animate2(object state)
        {
            IAsyncResult result = (IAsyncResult)state;

            while (!result.IsCompleted)
            {
                Console.Write(".");
                Thread.Sleep(50);
            }
        }
        static string LookupWord(string word)
        {
            Thread.Sleep(1000);
            return $"Статья для '{word}':\nСловарь КБИП";
        }
        static void Animate()
        {
            while (true)
            {
                Console.Write(".");
                Thread.Sleep(50);
            }
        }
        static void DoWork4(int id)
        {
            Console.WriteLine($"Задача {id}: начало работы");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Задача {id}: продолжение работы");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Задача {id}: завершение работы");
        }
        static void DoWork3() // 3.1
        {
            Console.WriteLine("Начало работы задачи");
            Thread.Sleep(1000);
            Console.WriteLine("Продолжение работы задачи");
            Thread.Sleep(1000);
            Console.WriteLine("Завершение работы задачи");
        }
        static void DoWork2()
        {
            Random random = new Random();
            int duration = random.Next(2000, 5000);

            Console.WriteLine($"{Thread.CurrentThread.Name} начал работу на {duration} ms");
            for (int i = 1; i <= duration / 1000; i++)
            {
                _sem.WaitOne(); // ожидание доступа к семафору
                Console.WriteLine($"{Thread.CurrentThread.Name}: Сообщение {i}");
                Thread.Sleep(1000);
                _sem.Release(); // освобождение семафора
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} закончил работу");
        }
        static void ThreadMethod()
        {
            Random random = new Random();
            int duration = random.Next(2000, 5000);
        
            _mutex.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} начал работать на {duration}ms");
            _mutex.ReleaseMutex();
        
            for (int i = 0; i < duration / 1000; i++)
            {
                Thread.Sleep(1000);
                _mutex.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} работает...");
                _mutex.ReleaseMutex();
            }
        
            _mutex.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} закончил работу");
            _mutex.ReleaseMutex();
        }
        static void DoWork(object state) // 2.3
        {
            AutoResetEvent ev = (AutoResetEvent)state;
            Random random = new Random();
            int duration = random.Next(2000, 5000);
            Console.WriteLine($"{Thread.CurrentThread.Name} начал работать на {duration}ms");
            Thread.Sleep(duration);
            Console.WriteLine($"{Thread.CurrentThread.Name} закончил работу");
            ev.Set();
        }
        private static void OnTimerElapsed(object state) // 1.4
        {
            ConsoleColor color = (ConsoleColor)state;

            lock (_lockObject)
            {
                int threadCount = Interlocked.Increment(ref _threadCount);
                Console.ForegroundColor = color;
                Console.WriteLine($"Thread {threadCount} elapsed at {DateTime.Now:hh:mm:ss.fff}");
                Console.ResetColor();
            }
        }
    }
}