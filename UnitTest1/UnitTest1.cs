namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        public decimal StartingBalance { get; set; }
        public UnitTest1()
        {
            StartingBalance = 500;
        }

        // Withdraw method should subtract the amount
        // withdrawn from the Balance of the Account
        [TestMethod]
        public void Withdraw_SubtractsFromBalance()
        {
            // Arrange
            decimal currentBalance = 500;
            decimal withdrawalAmount = 2.75M;
            decimal assertedBalance = currentBalance -
                withdrawalAmount;

            BankAccount account = new BankAccount();
            account.balance = currentBalance;

            // Act 
            account.Withdraw(withdrawalAmount);

            // Assert 
            Assert.AreEqual(assertedBalance,
                account.balance);
        }
    }
}