namespace LinqApplication.LinqApplication.Library.GenerateCollection
{
    public class GenerateCollectionExcercise2
    {
        public string BuildTree(int levels)
        {
            return string.Join("\n", Enumerable.Range(1, levels)
                         .Select(x => string.Join("", Enumerable.Repeat("*", x))));                             
        }
    }
}
