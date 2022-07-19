namespace IWantApp.Domain.Products
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public bool HasStock { get; set; }

        public Product(string name, Category category, string description, bool hasStock, string createdBy, DateTime createdOn, string editedBy, DateTime editedOn)
        {
            Name = name;
            Category = category;
            Description = description;
            HasStock = hasStock;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            EditedBy = editedBy;
            EditedOn = editedOn;
        }
    }
}