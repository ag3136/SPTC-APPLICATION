using System;
using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class PaymentDetailsTests
    {
        [Fact]
        public void WriteInto_AssignsProperties()
        {
            var payment = new PaymentDetails<Ledger.Loan>();
            var ledger = new Ledger.Loan();
            var date = new DateTime(2024, 1, 1);

            var result = payment.WriteInto(ledger, true, false, date, "REF", 100, 5, "remarks");

            Assert.True(result);
            Assert.Equal(ledger, payment.ledger);
            Assert.True(payment.isDownPayment);
            Assert.False(payment.isDivPat);
            Assert.Equal("REF", payment.referenceNo);
            Assert.Equal(100, payment.deposit);
            Assert.Equal(5, payment.penalties);
            Assert.Equal("remarks", payment.remarks);
        }

        [Fact]
        public void ToString_ReturnsNetDeposit()
        {
            var payment = new PaymentDetails<Ledger.Loan>();
            payment.deposit = 100;
            payment.penalties = 25;
            Assert.Equal("75", payment.ToString());
        }
    }
}
