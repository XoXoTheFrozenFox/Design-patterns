using Microsoft.EntityFrameworkCore;
using Orgoffering.Data;
using Orgoffering.Models;
using Orgoffering.Repository;

public class ServiceRepository : GenericRepository<Service>, IServiceRepository
{
    public ServiceRepository(DesignPatternsContext context) : base(context)
    {
    }

    public Service GetMostRecentService()
    {
        return _context.Services.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
    }
}


