using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrueba
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int s_accountNumberSeed = 1234567890;
<<<<<<< HEAD
        private readonly decimal _minimumBalance;

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
=======

        public BankAccount(string name, decimal initialBalance)
>>>>>>> 16e7a78c32673637e43bea5219df8bcc6a8ee861
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

<<<<<<< HEAD
            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
=======
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
>>>>>>> 16e7a78c32673637e43bea5219df8bcc6a8ee861
        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
<<<<<<< HEAD
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            _allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
=======
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
>>>>>>> 16e7a78c32673637e43bea5219df8bcc6a8ee861
        }

        public string GetAccountHistory()
        {
            var report  = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAccount\tBalance\tNote");
            foreach (var item in _allTransactions) 
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
        }

<<<<<<< HEAD
        public virtual void PerformMonthEndTransactions() { }
    }

=======
    }
>>>>>>> 16e7a78c32673637e43bea5219df8bcc6a8ee861
}
