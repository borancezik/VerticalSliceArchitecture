using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Data;
using VerticalSliceArchitecture.Features.Offices.Abstract;
using VerticalSliceArchitecture.Features.Offices.Models;

namespace VerticalSliceArchitecture.Features.Offices.Concrete
{
    public class OfficeRepository : BaseRepository<OfficeEntity, ApplicationContext>, IOfficeRepository
    {
        private readonly ApplicationContext _context;

        public OfficeRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
