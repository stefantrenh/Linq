
using FluentAssertions;
using LinqApplication.LinqApplication.Library.GenerateCollection;

namespace LinqApplication.Test.GenerateCollectionTest
{
    public class AddLevelsTest
    {
        protected string tree;
        protected GenerateCollectionExcercise2 generateCollectionExcercise2;

        public AddLevelsTest()
        {
            tree = "*\n**\n***\n****\n*****";
            generateCollectionExcercise2 = new GenerateCollectionExcercise2();
        }
    }

    public class BuildATreeTest : AddLevelsTest
    {
        [Fact]
        public void ShouldReturnTreeString()
        {
            var result = generateCollectionExcercise2.BuildTree(5);

            result.Should().BeEquivalentTo(tree);
        }
    }
}
