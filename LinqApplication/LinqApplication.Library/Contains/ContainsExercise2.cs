using LinqApplication.LinqApplication.Domain.Entities;


namespace LinqApplication.LinqApplication.Library.Contains
{
    public class ContainsExercise2
    {
        /*
         Implement the CountFriendsOf method. This method takes the friend parameter and a collection of people. 
         We want to count all those people, who have the friend amongst their friends.
         For example, in this case, the result of the method should be 3 because there are 3 people who have friend in their Friends collection.
         */
        public int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            return people.Count(x => x.Friends.Contains(friend));
        }
    }
}
