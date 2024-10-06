using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.ConcatAndUnion
{
    /*
     Imagine you are working on a news website. On the main panel of this website, we want to show the most important news, as well as the most recent ones.
    Implement the SelectRecentAndImportant method which given a collection of news will return the three most recent news, as well as all news with priority set to high.
    For example, for the following collection of news we will return the news in bold:

    2021/10/6 and priority high - because it has the high priority (and it's amongst 3 most recent news)
    2021/10/5 and priority low - because it's amongst 3 most recent news
    2021/10/4 and priority medium - because it's amongst 3 most recent news
    2021/10/3 and priority medium
    2021/10/2 and priority high - because it has the high priority
    2021/10/1 and priority low
     */
    public class ConcatAndUnionExercise1
    {
        public static IEnumerable<News> SelectRecentAndImportant(IEnumerable<News> newsCollection)
        {
            return newsCollection.OrderByDescending(x => x.PublishingDate)
                                 .Take(3)
                                 .Union(newsCollection.Where(x => x.Priority == Priority.High));
        }
    }

    public struct News
    {
        public DateTime PublishingDate { get; set; }
        public Priority Priority { get; set; }

        public override string ToString()
        {
            return $"Date: {PublishingDate.ToString("d")}, Priority: {Priority}";
        }
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
