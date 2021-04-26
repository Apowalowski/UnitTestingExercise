using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }
        // Create a Subtract method that passes 2 integers
        public int Subract(int mineued, int subtrahend)
        {
            return mineued - subtrahend;
        }
            // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string MyName()
        {
            string firstName = "Alexander";
            string lastName = "Powalowski";
            return $"{firstName} {lastName}";
        }
        public string MyFavoriteFood()
        {
            var favFood = "Spaghetti";
            return $"{favFood}";
        }

        
    }
}
