using System.Data.Entity;
using Model;

using System.Data.Entity.ModelConfiguration;

namespace DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Destination>().Property(d => d.Name).IsRequired();
        //    modelBuilder.Entity<Destination>().Property(d => d.Description).HasMaxLength(500);
        //    modelBuilder.Entity<Destination>().Property(d => d.Photo).HasColumnType("image");
        //    modelBuilder.Entity<Lodging>().Property(l => l.Name).IsRequired().HasMaxLength(200);
        //    //If you are wondering where HasMinLength is, there is no Fluent configuration
        //    //for minimum length, as it is not a facet of a database column.
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new DestinationConfiguration());
        //    modelBuilder.Configurations.Add(new LodgingConfiguration());
        //}

        //modelBuilder.Entity<Trip>().HasKey(t => t.Identifier);

        //modelBuilder.ComplexType<Address>();

        //modelBuilder.ComplexType<Address>().Property(p => p.StreetAddress).HasMaxLength(150);

    }


    public class AddressConfiguration :ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.StreetAddress).HasMaxLength(150);
        }
    }

    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            HasKey(t => t.Identifier);
            //this.HasKey(t => t.Identifier);
        }
    }


    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {           
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");
        }
    }
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(l => l.Name).IsRequired().HasMaxLength(200);

            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);
        }
    }

    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(p => p.SocialSecurityNumber).IsConcurrencyToken();
        }
    }



//    The DatabaseGeneratedOption can be configured on a particular property. You can append
//this configuration to the HasKey you applied earlier, for example:
//modelBuilder.Entity<Trip>()
//.HasKey(t => t.Identifier)
//.Property(t => t.Identifier)
//.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
//Or you can create a separate statement:
//modelBuilder.Entity<Person>()
//.HasKey(p => t.SocialSecurityNumber);
//modelBuilder.Entity<Person>()
//.Property(p => p.SocialSecurityNumber)
//.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

//    With DbModelBuilder, you configure the Property like this:
//modelBuilder.Entity<Person>()
//.Property(p => p.RowVersion).IsRowVersion();
//Inside an EntityTypeConfiguration<T> class the configuration looks like:
//Property(p => p.RowVersion).IsRowVersion();
    
    //Property(l => l.Owner).IsUnicode(false);





}