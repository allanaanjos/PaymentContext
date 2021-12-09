using System;
using PaymentContext.domain.ValuesObjects;

namespace PaymentContext.domain.Entities
{
   
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHoldName, 
        string cardNumber, 
        string lastTransactionNumber,
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        Document document, 
        string payer, 
        Address address, 
        Email email):base(paidDate,expireDate,total,totalPaid,document,payer,address,email)
        {
            CardHoldName = cardHoldName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHoldName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    } 

}