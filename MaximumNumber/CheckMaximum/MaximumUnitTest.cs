using NUnit.Framework;


namespace CheckMaximum
{
    public class MaximumUnitTests
    {
        
        [Test]
        public void GivenMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            int A = 10, B = 9, C = 5;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckMax(A, B, C);
            Assert.AreEqual(A, ActualResult);


        }
        [Test]
        public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            int A = 9, B = 10, C = 5;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckMax(A, B, C);
            Assert.AreEqual(B, ActualResult);


        }
        [Test]
        public void GivenMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            int A = 9, B = 5, C = 10;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckMax(A, B, C);
            Assert.AreEqual(C, ActualResult);


        }
    }
}
