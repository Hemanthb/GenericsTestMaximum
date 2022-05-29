using NUnit.Framework;


namespace CheckMaximum
{
    [TestFixture]
    public class MaximumUnitTests
    {
        
        [Test]
        public void GivenIntArray_CheckMaxValue_ReturnMaxValue()
        {

            int[] arr = { 34,2,5,1,56,7,8};
            MaximumNumber.GenericCheckMaximumOfThree<int> check = new MaximumNumber.GenericCheckMaximumOfThree<int>(arr);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(56, ActualResult);

        }
        [Test]
        public void GivenFloatArray_CheckMaxValue_ReturnMaxValue()
        {

            float[] arr = { 34.5f, 22.90f, 34.56f, 1.0f, 5.6f, 7.7f, 7.8f };
            MaximumNumber.GenericCheckMaximumOfThree<float> check = new MaximumNumber.GenericCheckMaximumOfThree<float>(arr);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual(34.56f, ActualResult);

        }
        [Test]
        public void GivenStringArray_CheckMaxValue_ReturnMaxValue()
        {

            string[] arr = { "harish","sai","yesh","zeus","ravi"};
            MaximumNumber.GenericCheckMaximumOfThree<string> check = new MaximumNumber.GenericCheckMaximumOfThree<string>(arr);
            var ActualResult = check.CheckMaximum();
            Assert.AreEqual("zeus", ActualResult);

        }
        
    }
}
