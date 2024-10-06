namespace LinqApplication.LinqApplication.Library.PrependAndAppend
{
    public class PrependAndAppendRefactoryChallange
    {
        //TODO implement this method
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker_Refactored(IEnumerable<string> words)
        {
            return words.TakeWhile(x => x != "The end").Append("END");
        }

        //TODO do not modify this method
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker(IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word != "The end")
                {
                    result.Add(word);
                }
                else
                {
                    break;
                }
            }
            result.Add("END");
            return result;
        }
    }
}
