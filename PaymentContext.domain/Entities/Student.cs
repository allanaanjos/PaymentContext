using System.Collections.Generic;
using System.Linq;
using PaymentContext.domain.ValuesObjects;
using Paymentontext.Shared.Entities;

namespace PaymentContext.domain.Entities
{
    public class Student : Entity
    { 
        private IList<Subscription> _subscription;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>(); 

            
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address  Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscription { get{return _subscription.ToArray();} } 

        public void AddSubscription(Subscription subscription){
            foreach (var sub in Subscription)
            {
                sub.Inactivate();
            }

            _subscription.Add(subscription);
        }


    }
}