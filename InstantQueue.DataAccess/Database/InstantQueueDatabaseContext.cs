using Microsoft.EntityFrameworkCore;

namespace InstantQueue.DataAccess.Database;

internal class InstantQueueDatabaseContext: DbContext
{
    protected InstantQueueDatabaseContext
    (
        DbContextOptions options
    ) : base(options)
    {
    }
    
    protected InstantQueueDatabaseContext
    (
        DbContextOptions<InstantQueueDatabaseContext> options
    ) : base(options)
    {
    }
}
