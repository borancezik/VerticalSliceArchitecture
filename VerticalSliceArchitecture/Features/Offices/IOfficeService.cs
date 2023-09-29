using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Offices
{
    public interface IOfficeService
    {
        OfficeEntity GetById(int id);
    }
}
