using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Offices
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;
        public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository= officeRepository;
        }

        public OfficeEntity GetById(int id)
        {
            return _officeRepository.GetById(id);
        }
    }
}
