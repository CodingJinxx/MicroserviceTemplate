using MicroserviceTemplate.Model.Entities;

namespace MicroserviceTemplate.Model.Entities
{
    public partial record ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string WeightWithUnit { get; set; }
        public string Size { get; set; }
        public int ColorId { get; set; }
        public ColorDto Color { get; set; }
    }
}