namespace LinqApplication.LinqApplication.Library.Count
{
    public class CountRefactorChallange
    {
        //TODO implement this method
        public bool IsAnySequenceTooLong_Refactored(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            return numberSequences.Any(x => x.Count() > maxLength);
        }

        //do not modify this method
        public bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            foreach (var numberSequence in numberSequences)
            {
                var count = 0;
                foreach (var number in numberSequence)
                {
                    ++count;
                }
                if (count > maxLength)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
