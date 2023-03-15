using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface IPaymentRepository
    {
        public IQueryable<Payment> Payments { get; }

        public void SavePayment(Payment payment);
    }
}
