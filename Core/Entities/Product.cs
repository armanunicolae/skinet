namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; } //By convention this Id will be PrimaryKey, Increment/Identity(1,1)
        public string Name { get; set; }
    }
}