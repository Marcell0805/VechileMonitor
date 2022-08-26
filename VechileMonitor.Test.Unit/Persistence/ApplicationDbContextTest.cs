using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using VechileMonitor.Domain.Entities;
using VechileMonitor.Persistence;

namespace VechileMonitor.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var customer = new Contractor();
            context.Customers.Add(customer);
            Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
