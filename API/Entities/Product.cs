namespace API.Entities
{

    public class Product
    {

        public int Id { get; set }

        public string Name { get;set }

        public string Discription { get; set }
        
        public long Price { get; set }

        public string PictureUrl { get; set }

        public string Tipe { get; set }

        public string Brand { get; set }

        public int QuantityinStock { get; set }
    }
}
