namespace LinqApplication.LinqApplication.Library.TypeOf
{
    public class TypeOfRefactorChallange
    {
        //TODO implement this method
        public static DateTime? GetTheLatestDate_Refactored(IEnumerable<object> objects)
        {
            return objects.OfType<DateTime?>()
                          .OrderByDescending(x => x)
                          .FirstOrDefault();
        }

        //do not modify this method
        public static DateTime? GetTheLatestDate(IEnumerable<object> objects)
        {
            DateTime? lastDate = null;
            foreach (var obj in objects)
            {
                var dateTime = obj as DateTime?;
                if (dateTime != null)
                {
                    if (lastDate == null || lastDate < dateTime)
                    {
                        lastDate = dateTime;
                    }
                }
            }
            return lastDate;
        }
    }
}
