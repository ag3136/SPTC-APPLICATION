using System;
using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class LedgerTests
    {
        [Fact]
        public void Loan_WriteInto_AssignsProperties()
        {
            var loan = new Ledger.Loan();
            var date = new DateTime(2024, 1, 1);
            var result = loan.WriteInto(1, date, 100, "details", 2, 3, 4);
            Assert.True(result);
            Assert.Equal(1, loan.franchiseId);
            Assert.Equal(date, loan.date);
            Assert.Equal(100, loan.amount);
            Assert.Equal("details", loan.details);
        }

        [Fact]
        public void ShareCapital_WriteInto_AssignsProperties()
        {
            var shareCapital = new Ledger.ShareCapital();
            var date = new DateTime(2024, 2, 2);
            var result = shareCapital.WriteInto(2, date, 10, 20);
            Assert.True(result);
            Assert.Equal(2, shareCapital.franchiseId);
            Assert.Equal(10, shareCapital.beginningBalance);
            Assert.Equal(20, shareCapital.lastBalance);
        }

        [Fact]
        public void LongTermLoan_WriteInto_AssignsProperties()
        {
            var loan = new Ledger.LongTermLoan();
            var date = new DateTime(2024, 3, 3);
            var start = new DateTime(2024, 4, 1);
            var end = new DateTime(2025, 4, 1);
            var result = loan.WriteInto(3, date, 12, start, end, 1000, "lt", 50, 25);
            Assert.True(result);
            Assert.Equal(3, loan.franchiseId);
            Assert.Equal(12, loan.termsOfPaymentMonth);
            Assert.Equal(1000, loan.amountLoaned);
        }
    }
}
