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
            var ActualResult = check.CheckIntMax(A, B, C);
            Assert.AreEqual(A, ActualResult);


        }
        [Test]
        public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            int A = 9, B = 10, C = 5;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckIntMax(A, B, C);
            Assert.AreEqual(B, ActualResult);


        }
        [Test]
        public void GivenMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            int A = 9, B = 5, C = 10;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckIntMax(A, B, C);
            Assert.AreEqual(C, ActualResult);
        }
        [Test]
        public void GivenFloatMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            float A = 10.90f, B = 10.5f, C = 5.0f;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckFloatMax(A, B, C);
            Assert.AreEqual(A, ActualResult);


        }
        [Test]
        public void GivenFloatMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            float A = 10.90f, B = 10.98f, C = 5.0f;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckFloatMax(A, B, C);
            Assert.AreEqual(B, ActualResult);

        }
        [Test]
        public void GivenFloatMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            float A = 9.0f, B = 5.25f, C = 10.3f;
            MaximumNumber.CheckMaximumOfThree check = new MaximumNumber.CheckMaximumOfThree();
            var ActualResult = check.CheckFloatMax(A, B, C);
            Assert.AreEqual(C, ActualResult);

        }
    }
}
