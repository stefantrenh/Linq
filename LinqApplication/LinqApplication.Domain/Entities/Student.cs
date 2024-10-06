namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public IEnumerable<int> Marks { get; set; }

        public override string ToString()
        {
            return $"{Name} with marks ({string.Join(",", Marks)})";
        }
    }
}
