using LinqApplication.LinqApplication.Domain.Enums;


namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class Pet
    {
        public int Id { get; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public float Weight { get; set; }

        public Pet(int id, string name, PetType petType, float weight)
        {
            Id = id;
            Name = name;
            PetType = petType;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
        }
    }
}
