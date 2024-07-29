namespace LinqApplication.LinqApplication.Library.Sum
{
    /*
    Implement the TotalLength method, which given a collection of words will calculate the sum of their lengths.
    For example, for words {"little", "brown", "fox"} the result shall be 14 because the lengths of those words are 6, 5, and 3, which sums up to 14.
    Assume the result is not null
     */

    public class SumExcercise1
    {
        public int TotalLength(IEnumerable<string> words)
        {
            return words.Sum(word => word.Length);
        }
    }
}
