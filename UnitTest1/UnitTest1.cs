namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        public decimal StartingBalance { get; set; }
        public BankAccount TestAccount { get; set; } = new BankAccount();
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

        [TestMethod]
        public void AccountDeposit_AddsToBalance()
        {
            // arrange 
            decimal depositAmount = 125.32M;
            decimal currentBalance = 500;
            decimal assertedBalance = depositAmount + currentBalance;

            BankAccount account = new BankAccount();
            account.balance = currentBalance;

            // act
            account.Deposit(depositAmount);

            // assert
            Assert.AreEqual(assertedBalance,
                account.balance);
        }

        //[TestMethod]
        //public void AccountDeposit_ThrowsExceptionOnZeroOrNegativeAmount()
        //{
        //    // arrange
        //    decimal firstDepositAmount = 0;
        //    decimal secondDepositAmount = -123;

        //    // act and assert
        //    Assert.ThrowsException<ArgumentException>(() =>
        //    {
        //        TestAccount.Deposit(firstDepositAmount);
        //    });

        //    Assert.ThrowsException<ArgumentException>(() =>
        //    {
        //        TestAccount.Deposit(secondDepositAmount);
        //    });
        //}

        [TestMethod]
        public void AccountBalance_ChecksBalance()
        {
            // arrange
            decimal balance = 500;
            decimal assertedBalance = balance;

            BankAccount account = new BankAccount();
            account.balance = balance;

            //act
            account.CheckBalance();

            // assert
            Assert.AreEqual(assertedBalance,
                account.balance);
            
        }
    }
}