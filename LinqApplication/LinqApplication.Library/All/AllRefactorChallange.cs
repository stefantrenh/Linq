namespace LinqApplication.LinqApplication.Library.All
{
    public class AllRefactorChallange
    {
        //TODO implement this method
        public static bool AreAllWordsOfTheSameLength_Refactored(List<string> words)
        {
            return words.All(x => x.Length == words[0].Length);
        }

        //do not modify this method
        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {
                return true;
            }
            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; ++i)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
