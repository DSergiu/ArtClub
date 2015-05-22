namespace DAL
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;

    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Email).IsRequired();

            // Table & Column Mappings
            ToTable("Members");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.EmployeeNo).HasColumnName("EmployeeNo");
            Property(t => t.Gender).HasColumnName("Gender");
            Property(t => t.IsBoard).HasColumnName("IsBoard");
            Property(t => t.IsCancelled).HasColumnName("IsCanceled");
            Property(t => t.Name).HasColumnName("Name").HasMaxLength(40);
            Property(t => t.Points).HasColumnName("Points");
            Property(t => t.CreateAt).HasColumnName("CreateAt");
        }
    }
}
