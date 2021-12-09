using System;
using System.Collections.Generic;

namespace PaymentContext.domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payment;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUptadeDate = DateTime.Now;
            ExpireDate = (DateTime)expireDate;
            Active = true;
            Payment = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUptadeDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public bool Active { get; private set; } 
        public IReadOnlyCollection<Payment> Payment { get; private set; }

        public void AddPayment(Payment payment){
            _payment.Add(payment);
        }

        public void Activate(){
            Active =true;
            LastUptadeDate = DateTime.Now;
        } 

        public void Inactivate(){
            Active =false;
            LastUptadeDate = DateTime.Now;
        }
    }
}