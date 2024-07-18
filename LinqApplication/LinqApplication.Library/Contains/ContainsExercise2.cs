using LinqApplication.LinqApplication.Domain.Entities;


namespace LinqApplication.LinqApplication.Library.Contains
{
    public class ContainsExercise2
    {
        public int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            return people.Count(x => x.Friends.Contains(friend));
        }
    }
}
