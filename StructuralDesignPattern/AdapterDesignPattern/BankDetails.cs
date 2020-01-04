using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.AdapterDesignPattern
{
   public class BankDetails
    {
        private string BankName;
        private int BankAccount;
        private string AccountHolderName;
        public void SetBankName(string BankName)
        {
            this.BankName = BankName;    
        }
        public void SetAccountHolderName(string AccountholderName)
        {
            this.AccountHolderName = AccountholderName;
        }
        public void setBankAccount(int AccountNumber)
        {
            this.BankAccount = AccountNumber;
        }

        public string GetBankName()
        {
            return this.BankName;
        }
        public string GetAccountHolderName()
        {
            return this.AccountHolderName;
        }
        public int GetAccountNumber()
        {
            return this.BankAccount;
        }
    }
}
