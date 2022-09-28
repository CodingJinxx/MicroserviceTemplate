using System.Reflection;
using Mapster;
using MicroserviceTemplate.Model.Entities;

namespace MicroserviceTemplate.DTO;

public class MapsterRegister : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        config.AdaptTo("[name]Dto")
            .ForAllTypesInNamespace(Assembly.GetAssembly(typeof(Product)) ?? throw new InvalidOperationException(), "MicroserviceTemplate.Model.Entities");
        
        config.GenerateMapper("[name]Mapper")
          .ForAllTypesInNamespace(Assembly.GetAssembly(typeof(Product)) ?? throw new InvalidOperationException(), "MicroserviceTemplate.Model.Entities");
    }
}
