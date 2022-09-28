using Autofac;
using MicroserviceTemplate.Core.Interfaces;
using MicroserviceTemplate.Core.Services;

namespace MicroserviceTemplate.Core;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope();
    }
}