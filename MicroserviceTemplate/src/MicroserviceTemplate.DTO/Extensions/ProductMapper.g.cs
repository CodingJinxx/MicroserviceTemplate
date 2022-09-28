using System.Collections.Generic;
using Mapster;
using MicroserviceTemplate.Model.Entities;

namespace MicroserviceTemplate.Model.Entities
{
    public static partial class ProductMapper
    {
        private static TypeAdapterConfig TypeAdapterConfig1;
        
        public static ProductDto AdaptToDto(this Product p1)
        {
            return p1 == null ? null : new ProductDto()
            {
                Id = p1.Id,
                Name = p1.Name,
                Brand = p1.Brand,
                WeightWithUnit = p1.WeightWithUnit,
                Size = p1.Size,
                ColorId = p1.ColorId,
                Color = funcMain1(p1.Color)
            };
        }
        public static ProductDto AdaptTo(this Product p4, ProductDto p5)
        {
            if (p4 == null)
            {
                return null;
            }
            ProductDto result = p5 ?? new ProductDto();
            
            result.Id = p4.Id;
            result.Name = p4.Name;
            result.Brand = p4.Brand;
            result.WeightWithUnit = p4.WeightWithUnit;
            result.Size = p4.Size;
            result.ColorId = p4.ColorId;
            result.Color = funcMain3(p4.Color, result.Color);
            return result;
            
        }
        
        private static ColorDto funcMain1(Color p2)
        {
            return p2 == null ? null : new ColorDto()
            {
                Id = p2.Id,
                Name = p2.Name,
                Products = funcMain2(p2.Products)
            };
        }
        
        private static ColorDto funcMain3(Color p6, ColorDto p7)
        {
            if (p6 == null)
            {
                return null;
            }
            ColorDto result = p7 ?? new ColorDto();
            
            result.Id = p6.Id;
            result.Name = p6.Name;
            result.Products = funcMain4(p6.Products, result.Products);
            return result;
            
        }
        
        private static List<ProductDto> funcMain2(List<Product> p3)
        {
            if (p3 == null)
            {
                return null;
            }
            List<ProductDto> result = new List<ProductDto>(p3.Count);
            
            int i = 0;
            int len = p3.Count;
            
            while (i < len)
            {
                Product item = p3[i];
                result.Add(TypeAdapterConfig1.GetMapFunction<Product, ProductDto>().Invoke(item));
                i++;
            }
            return result;
            
        }
        
        private static List<ProductDto> funcMain4(List<Product> p8, List<ProductDto> p9)
        {
            if (p8 == null)
            {
                return null;
            }
            List<ProductDto> result = new List<ProductDto>(p8.Count);
            
            int i = 0;
            int len = p8.Count;
            
            while (i < len)
            {
                Product item = p8[i];
                result.Add(TypeAdapterConfig1.GetMapFunction<Product, ProductDto>().Invoke(item));
                i++;
            }
            return result;
            
        }
    }
}