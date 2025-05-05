namespace OM.Entity.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public List<Product> Products { get; set; } // Navigation property to the Product entity


    }
}
