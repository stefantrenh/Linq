namespace LinqApplication.LinqApplication.Library.Select
{
    /*
     Imagine you work on an application that retrieves data from scanned paper documents. Those documents contain personal data which you want to convert to C# objects.
        Implement the PeopleFromString method, which given a single string containing personal data of multiple people, will return a collection of people. If a person's data is not valid and can't be properly parsed, this person should not be included in the result collection.
        For example, for an input string:
            "John Smith, 1983/08/21;Jane Doe, 1993/12/21;Francis Brown, invalid date here"
            ...the result shall be a collection of two people: John Smith and Jane Doe. We shall not include Francis Brown, because his date of birth is not valid and can't be parsed to a valid DateTime.
            As you can see in the example the separator between each person's data is ";", and the full name and the date of birth are separated with ",".
     */
    internal class SelectExcercise2
    {
        public static IEnumerable<Person> PeopleFromString(string input)
        {
            return input.Split(";").Select(GetPersonFromString)
                                   .Where(x => x != null);
        }

        private static Person GetPersonFromString(string personData)
        {
            try
            {
                var split = personData.Split(',');
                var fullName = split[0].Split(' ');
                var firstName = fullName[0];
                var lastName = fullName[1];
                var dateOfBirth = DateTime.Parse(split[1]);

                return new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = DateTime.Now,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }


    /*
         Already got a person class , but it wont fit in Udemy for course tests.
     */
    public class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} born on {DateOfBirth.ToString("d")}";
        }

        public bool Equals(Person other)
        {
            return FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   DateOfBirth == other.DateOfBirth;
        }
    }
}
