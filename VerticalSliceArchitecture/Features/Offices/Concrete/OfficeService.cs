using VerticalSliceArchitecture.Features.Offices.Abstract;
using VerticalSliceArchitecture.Features.Offices.Models;

namespace VerticalSliceArchitecture.Features.Offices.Concrete
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;
        public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public List<OfficeEntity> GetAll()
        {
            return _officeRepository.GetAll();
        }

        public OfficeEntity GetById(int id)
        {
            return _officeRepository.GetById(id);
        }

        public OfficeEntity Add(OfficeEntity officeEntity)
        {
            return _officeRepository.Add(officeEntity);
        }

        public OfficeEntity Update(OfficeEntity officeEntity)
        {
            return _officeRepository.Update(officeEntity);
        }

        public OfficeEntity Delete(OfficeEntity officeEntity)
        {
            return _officeRepository.Delete(officeEntity);
        }
    }
}
