
using FluentAssertions;
using LinqApplication.LinqApplication.Library.Count;

namespace LinqApplication.Test.CountTest
{
    public class StringCountLenghtTest
    {
        protected List<string> _words;
        protected readonly CountExercise1 _countExercise;

        public StringCountLenghtTest()
        {
            _countExercise = new CountExercise1();
            _words = CreateStringMockList(5);
        }

        private List<string> CreateStringMockList(int count)
        {
            var wordList = new List<string>();

            for (int i = 0; i < count; i++)
            {
                var word = new Guid().ToString();
                wordList.Add(word);
            }

            return wordList;
        }
    }

    public class Words_Contains_More_Than_10_Chars : StringCountLenghtTest
    {
        [Fact]
        public void Count_Should_Be_5()
        {
            var result = _countExercise.CountAllLongWords(_words);

            result.Should().Be(5);
        }
    }

    public class Words_Contains_No_More_Than_10_Chars : StringCountLenghtTest
    {
        [Fact]
        public void Count_Should_Be_0() 
        {
            var newWordList = new List<string>();

            for (int i = 0; i < _words.Count; i++)
            {
                newWordList.Add(_words[i].Substring(0,7));
            }

            var result = _countExercise.CountAllLongWords(newWordList);

            result.Should().Be(0);
        }
    }
}
