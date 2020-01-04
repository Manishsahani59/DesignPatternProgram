using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.AdapterDesignPattern
{
    public class BankCustomer : BankDetails,CreaditCard 
    {
        public void getBankDetails()
        {
            string _AccountHolderName;
            int _BankAccount;
            string _BankName;
            try
            {
                Console.WriteLine("Enter the Bank Name");
                _BankName = Console.ReadLine();
                Console.WriteLine("Enter the Account Holder Name");
                _AccountHolderName = Console.ReadLine();
                Console.WriteLine("Enter the Account Number");
                _BankAccount = Convert.ToInt32(Console.ReadLine());
                 setBankAccount(_BankAccount);
                 SetBankName(_BankName);
                 SetAccountHolderName(_AccountHolderName);
             
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getCrearitCard()
        {
            return "Account Number "+GetAccountNumber() + " is Valid And Customer " +GetAccountHolderName()+" is Validated That he is the customer of "+GetBankName() +" he can Get the Creadit Card";
        }
    }
}
