namespace AMST4.Store.Shoes.Models.Entities
{
    public class Product
    {
        public Guid Id {get; set;}
        public string Brand {get; set;}
        public string Description {get; set;}
        public Guid ColorId {get; set;}
        public Guid SizeId {get; set;}
        public double Price {get; set;}
        public double Stock {get; set;}
        public bool IsActive {get; set;}
        public DateTime CreatedBy {get; set;}
        

        
    }
}