

using FluentAssertions;
using LinqApplication.LinqApplication.Library.Count;
using LinqApplication.Test.AnyTest;

namespace LinqApplication.Test.CountTest
{
    public class GreaterThanNumberSequenceComparerTest
    {
        protected readonly int[] moreOddNumberArray;
        protected readonly int[] moreEvenNumberArray;
        protected CountExercise2 _countExercise2;

        public GreaterThanNumberSequenceComparerTest()
        {
            moreOddNumberArray = new int[] 
            { 
                1 , 2 , 3 , 4 , 5
            };

            moreEvenNumberArray = new int[]
            { 
                2, 4 , 6 , 1 , 3
            };

            _countExercise2 = new CountExercise2();
        }
    }

    public class More_OddNumbers_Than_Even_Test : GreaterThanNumberSequenceComparerTest
    {
        [Fact]
        public void Should_Return_False()
        { 
            var result = _countExercise2.AreThereFewerOddThanEvenNumbers(moreOddNumberArray);

            result.Should().BeFalse();
        }
    }

    public class More_EvenNumbers_Than_Odd_Test : GreaterThanNumberSequenceComparerTest
    {
        [Fact]
        public void Should_Return_True() 
        {
            var result = _countExercise2.AreThereFewerOddThanEvenNumbers(moreEvenNumberArray);

            result.Should().BeTrue();
        }
    }
}
