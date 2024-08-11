namespace LinqApplication.LinqApplication.Library.Distinct
{
    public class DistinctRefactoryChallange
    {
        //TODO implement this method
        public static IEnumerable<string> GetWordsShorterThan5Letters_Refactored(IEnumerable<string> words)
        {
            return words.Where(x => x.Length < 5).Distinct();
        }

        //do not modify this method
        public static IEnumerable<string> GetWordsShorterThan5Letters(IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5 && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
