using VerticalSliceArchitecture.Features.Offices.Models;

namespace VerticalSliceArchitecture.Features.Offices.Abstract
{
    public interface IOfficeService
    {
        OfficeEntity GetById(int id);
        List<OfficeEntity> GetAll();
        OfficeEntity Add(OfficeEntity officeEntity);
        OfficeEntity Update(OfficeEntity officeEntity);
        OfficeEntity Delete(OfficeEntity officeEntity);
    }
}
