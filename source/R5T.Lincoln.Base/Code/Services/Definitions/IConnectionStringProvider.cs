using System;

using R5T.T0064;


namespace R5T.Lincoln
{
    [ServiceDefinitionMarker]
    public interface IConnectionStringProvider : IServiceDefinition
    {
        string GetConnectionString();
    }
}
