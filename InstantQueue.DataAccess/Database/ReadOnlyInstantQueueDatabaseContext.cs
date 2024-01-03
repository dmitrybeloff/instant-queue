using InstantQueue.DataAccess.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InstantQueue.DataAccess.Database;

internal class ReadOnlyInstantQueueDatabaseContext: InstantQueueDatabaseContext, IReadOnlyInstantQueueDatabaseContext
{
    private const string ThisContextIsReadOnly = "This context is read-only.";

    protected ReadOnlyInstantQueueDatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected ReadOnlyInstantQueueDatabaseContext(DbContextOptions<InstantQueueDatabaseContext> options) : base(options)
    {
    }

    public override int SaveChanges()
    {
        throw new InvalidOperationException(ThisContextIsReadOnly);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        throw new InvalidOperationException(ThisContextIsReadOnly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        throw new InvalidOperationException(ThisContextIsReadOnly);
    }

    public override Task<int> SaveChangesAsync
    (
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new()
    )
    {
        throw new InvalidOperationException(ThisContextIsReadOnly);
    }
}
