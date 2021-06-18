using Data.Entities;
using Service.Filters;
using Service.Interfaces.Common;

namespace Service.Interfaces
{
    public interface IShiftService : IService<Shift, ShiftFilter>
    {
        
    }
}