using NUnit.Framework;


namespace CheckMaximum
{
    [TestFixture]
    public class MaximumUnitTests
    {
        
        [Test]
        public void GivenMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            int A = 10, B = 9, C = 5;
            MaximumNumber.GenericCheckMaximumOfThree<int> check = new MaximumNumber.GenericCheckMaximumOfThree<int>(A,B,C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(A, ActualResult);

        }
        [Test]
        public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            int A = 9, B = 10, C = 5;
            MaximumNumber.GenericCheckMaximumOfThree<int> check = new MaximumNumber.GenericCheckMaximumOfThree<int>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(B, ActualResult);


        }
        [Test]
        public void GivenMaxInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            int A = 9, B = 5, C = 10;
            MaximumNumber.GenericCheckMaximumOfThree<int> check = new MaximumNumber.GenericCheckMaximumOfThree<int>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(C, ActualResult);
        }
        [Test]
        public void GivenFloatMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            float A = 10.90f, B = 10.5f, C = 5.0f;
            MaximumNumber.GenericCheckMaximumOfThree<float> check = new MaximumNumber.GenericCheckMaximumOfThree<float>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(A, ActualResult);


        }
        [Test]
        public void GivenFloatMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            float A = 10.90f, B = 10.98f, C = 5.0f;
            MaximumNumber.GenericCheckMaximumOfThree<float> check = new MaximumNumber.GenericCheckMaximumOfThree<float>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(B, ActualResult);

        }
        [Test]
        public void GivenFloatMaxInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            float A = 9.0f, B = 5.25f, C = 10.3f;
            MaximumNumber.GenericCheckMaximumOfThree<float> check = new MaximumNumber.GenericCheckMaximumOfThree<float>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(C, ActualResult);

        }
        [Test]
        public void GivenStringMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            string A = "rejeesh", B = "Bharathan", C = "Hemanth";
            MaximumNumber.GenericCheckMaximumOfThree<string> check = new MaximumNumber.GenericCheckMaximumOfThree<string>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(A, ActualResult);

        }
        [Test]
        public void GivenStringMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {
            string A = "Hemanth", B = "vysagh", C = "Bharathan";
            MaximumNumber.GenericCheckMaximumOfThree<string> check = new MaximumNumber.GenericCheckMaximumOfThree<string>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(B, ActualResult);
            

        }
        [Test]
        public void GivenStringMaxInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {
            string A = "Hemanth", B = "Asha", C = "Vysagh";
            MaximumNumber.GenericCheckMaximumOfThree<string> check = new MaximumNumber.GenericCheckMaximumOfThree<string>(A, B, C);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(C, ActualResult);
        }
    }
}
