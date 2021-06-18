using Data.Entities;
using Service.Filters;
using Service.Interfaces.Common;

namespace Service.Interfaces
{
    public interface IStopService : IService<Stop, EmptyFilter>
    {
        
    }
}