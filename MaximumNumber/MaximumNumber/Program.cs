// See https://aka.ms/new-console-template for more information
int[] arr = { 5, 3, 4, 56, 1, 3, 4 };
MaximumNumber.GenericCheckMaximumOfThree<int> genericCheckMaximum = new MaximumNumber.GenericCheckMaximumOfThree<int>(arr);
Console.WriteLine(genericCheckMaximum.CheckMaximum());