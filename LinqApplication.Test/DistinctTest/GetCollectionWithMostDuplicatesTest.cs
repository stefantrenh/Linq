using FluentAssertions;
using LinqApplication.LinqApplication.Library.Distinct;

namespace LinqApplication.Test.DistinctTest
{
    public class GetCollectionWithMostDuplicatesTest
    {
        protected DistinctExcercise2 distinctExcercise2;
        protected List<List<int>> ints;

        public GetCollectionWithMostDuplicatesTest()
        {
            distinctExcercise2 = new DistinctExcercise2();
            ints = CreateIntsLists();
        }

        [Fact]
        protected void Get_Shortest_Duplicate_IntList_Test()
        {
            var intList = new List<int>() { 1, 2, 3, 3, 4, 4, 4 };
            var result = distinctExcercise2.GetCollectionWithMostDuplicates(ints);

            result.Should().BeEquivalentTo(intList);
        }

        private List<List<int>> CreateIntsLists() 
        {
            var intsList = new List<List<int>>();

            var list = new List<int>() { 1,2,3,4};
            var list2 = new List<int>() { 1,2,3,3,4,4,4};           
            var list3 = new List<int>() { 1,2,3,3,4,4,4,5,6,7};
            
            intsList.Add(list);
            intsList.Add(list2);
            intsList.Add(list3);

            return intsList;
        }
    }
}
