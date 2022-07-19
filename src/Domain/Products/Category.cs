namespace IWantApp.Domain.Products
{
    public class Category : Entity
    {
        public string Name { get; set; }


        public Category(string name, string createdBy, DateTime createdOn, string editedBy, DateTime editedOn)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            EditedBy = editedBy;
            EditedOn = editedOn;
        }
    }
}
