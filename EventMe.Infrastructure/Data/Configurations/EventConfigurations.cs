using EventMe.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EventMe.Infrastructure.Data.Configurations
{
    public class EventConfigurations:IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .HasQueryFilter(e => e.IsActive);
        }
    }
}
