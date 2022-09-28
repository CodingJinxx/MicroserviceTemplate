using System.Collections.Generic;
using Mapster;
using MicroserviceTemplate.Model.Entities;

namespace MicroserviceTemplate.Model.Entities
{
    public static partial class ColorMapper
    {
        private static TypeAdapterConfig TypeAdapterConfig1;
        
        public static ColorDto AdaptToDto(this Color p1)
        {
            return p1 == null ? null : new ColorDto()
            {
                Id = p1.Id,
                Name = p1.Name,
                Products = funcMain1(p1.Products)
            };
        }
        public static ColorDto AdaptTo(this Color p3, ColorDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            ColorDto result = p4 ?? new ColorDto();
            
            result.Id = p3.Id;
            result.Name = p3.Name;
            result.Products = funcMain2(p3.Products, result.Products);
            return result;
            
        }
        
        private static List<ProductDto> funcMain1(List<Product> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<ProductDto> result = new List<ProductDto>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Product item = p2[i];
                result.Add(item == null ? null : new ProductDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Brand = item.Brand,
                    WeightWithUnit = item.WeightWithUnit,
                    Size = item.Size,
                    ColorId = item.ColorId,
                    Color = TypeAdapterConfig1.GetMapFunction<Color, ColorDto>().Invoke(item.Color)
                });
                i++;
            }
            return result;
            
        }
        
        private static List<ProductDto> funcMain2(List<Product> p5, List<ProductDto> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            List<ProductDto> result = new List<ProductDto>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Product item = p5[i];
                result.Add(item == null ? null : new ProductDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Brand = item.Brand,
                    WeightWithUnit = item.WeightWithUnit,
                    Size = item.Size,
                    ColorId = item.ColorId,
                    Color = TypeAdapterConfig1.GetMapFunction<Color, ColorDto>().Invoke(item.Color)
                });
                i++;
            }
            return result;
            
        }
    }
}