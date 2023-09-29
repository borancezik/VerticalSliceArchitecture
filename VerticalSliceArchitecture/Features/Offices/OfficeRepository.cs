using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Data;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Offices
{
    public class OfficeRepository : BaseRepository<OfficeEntity,ApplicationContext>,IOfficeRepository
    {
        private readonly ApplicationContext _context;

        public OfficeRepository(ApplicationContext context) : base(context)
        {
            _context= context;  
        }
    }
}
