using System.Collections.Generic;
using MicroserviceTemplate.Model.Entities;

namespace MicroserviceTemplate.Model.Entities
{
    public partial record ColorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}