using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    internal class Program
    {
        public class BankAccount
        {
            public double AccountNumber { get; set; } // номер счёта
            public string OwnerFullName { get; set; } // ФИО владельца
            public decimal Balance { get; set; } // баланс
            public DateTime OpenDate { get; set; } // дата открытия
            public int AnnualInterestRate { get; set; } // годовой процент начисления
            public BankAccount (){ }

            public BankAccount(double accountNumber, string ownerFullName, decimal balance, DateTime openDate,
                int annualInterestRate)
            {
                if (accountNumber.ToString().Length != 12)
                {
                    throw new ArgumentException("Номер счёта должен состоять из 12 цифр (целое неотрицательное 12-ти знаковое число)!");
                }
                if (!char.IsUpper(ownerFullName[0]))
                {
                    throw new ArgumentException("Имя владельца должно начинаться с заглавной буквы!");
                }
                if (annualInterestRate < 0 || annualInterestRate > 100)
                {
                    throw new ArgumentException("Процент начисления должен быть целым не отрицательным со знаком «%» в конце значения, не превышающим 100% числом!");
                }
                AccountNumber = accountNumber;
                OwnerFullName = ownerFullName;
                Balance = balance;
                OpenDate = openDate;
                AnnualInterestRate = annualInterestRate;
            }
        }

        public class BankMenu
        {
            public static List<BankAccount> _accounts = new List<BankAccount>();

            public static void AddAccount(BankAccount account)
            {
                _accounts.Add(account);
            }

            public static IEnumerable<BankAccount> SortByOpenDateAndOwnerFullName() // Одновременная сортировка по дате открытия счета и ФИО владельца
            {
                return _accounts.OrderBy(a => a.OpenDate).ThenBy(a => a.OwnerFullName);
            }
            
            public static IEnumerable<double> GetAccountNumbersWithSameOwner() // Вывести номера счетов, имеющих одинакового владельца
            {
                /*
                Сначала, мы группируем счета по ФИО владельца с помощью метода GroupBy.
                Затем, мы используем метод Where для фильтрации групп, где количество элементов больше 1, так как это означает, что у этих владельцев есть несколько счетов.
                Наконец, мы используем метод SelectMany для выбора номеров счетов из каждой группы счетов.
                Общий выход этого метода – это перечисление номеров счетов, которые имеют одинаковых владельцев.
                */
                return _accounts
                    .GroupBy(a => a.OwnerFullName)
                    .Where(g => g.Count() > 1)
                    .SelectMany(g => g.Select(a => a.AccountNumber));
            }

            public static IEnumerable<string> GetOwnersWithAccountsOpenDateIn2013() // Вывести ФИО владельцев, открывших свой счет в 2013 году
            {
                return _accounts.Where(a => a.OpenDate.Year == 2013).Select(a => a.OwnerFullName);
            }

            public static decimal GetMaxBalanceWithAnnualInterestRate() // Вывести максимальную сумму на счете на текущий момент с учетом начисленных процентов за весь период существования счета
            {
                return _accounts.Max(a => a.Balance * (1 + (a.AnnualInterestRate / 100)));
            }

            public static IEnumerable<IGrouping<object, BankAccount>> GroupByFields() // Выполнить группировку по каждому полю
            {
                return _accounts.GroupBy(a => new { a.AccountNumber, a.OwnerFullName, a.Balance, a.OpenDate, a.AnnualInterestRate });
            }
        }
        
        private static void Main()
        {
            BankMenu.AddAccount(new BankAccount(124126443213, "Александр Зеневич", 50000, new DateTime(2023, 02, 12), 0));
            BankMenu.AddAccount(new BankAccount(643291923959, "Иван Тараскевич", 50020, new DateTime(2023, 4, 4), 20));
            BankMenu.AddAccount(new BankAccount(212312394291, "Влад Лазовский", 2500, new DateTime(2023, 3, 1), 20));
            BankMenu.AddAccount(new BankAccount(425517283192, "Влад Лазовский", 0, new DateTime(2013, 12, 12), 99));

            Console.WriteLine("Одновременная сортировка по дате открытия счета и ФИО владельца:");
            foreach (var account in BankMenu.SortByOpenDateAndOwnerFullName())
            {
                Console.WriteLine($"Номер счета: {account.AccountNumber}, ФИО: {account.OwnerFullName}, Дата открытия счёта: {account.OpenDate.ToShortDateString()}");
            }

            Console.WriteLine("\nНомера счетов, имеющих одинакового владельца:");
            foreach (var accountNumber in BankMenu.GetAccountNumbersWithSameOwner())
            {
                Console.WriteLine(accountNumber);
            }

            Console.WriteLine("\nФИО владельцев, открывших свой счет в 2013 году:");
            foreach (var owner in BankMenu.GetOwnersWithAccountsOpenDateIn2013())
            {
                Console.WriteLine(owner);
            }

            Console.WriteLine("\nМаксимальную сумму на счете на текущий момент с учетом начисленных процентов за весь период существования счета:");
            Console.WriteLine(BankMenu.GetMaxBalanceWithAnnualInterestRate());

            Console.WriteLine("\nГруппировка по каждому полю:");
            foreach (var group in BankMenu.GroupByFields())
            {
                Console.WriteLine($"Ключ: {group.Key}");
            }
        }
    }
}
