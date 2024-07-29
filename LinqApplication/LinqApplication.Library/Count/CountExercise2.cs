namespace LinqApplication.LinqApplication.Library.Count
{
    public class CountExercise2
    {
        /*
         Using LINQ, implement the AreThereFewerOddThanEvenNumbers method, which will check if in the collection of numbers there are fewer odd than even numbers.

            For example:
                {2,3,4,5,6} -> will return true, because there are 3 even numbers (2,4,6) and 2 odd numbers (3,5)
                {3,4,5} ->  will return false, because there is 1 even number (4) and 2 odd numbers (3,5)
                {2,3,4,5} ->  will return false, because there are 2 even numbers (2,4) and 2 odd numbers (3,5)

            Remember, you can check if the number is even by using the modulo operation:

            number % 2 == 0 means the number is even
            number % 2 != 0 means the number is odd
         
         */
        public bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Count(n => n % 2 == 0) > numbers.Count(n => n % 2 != 0);
        }
    }
}
