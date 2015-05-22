namespace DAL
{
    using System;
    using System.Data.Entity;
    using Domain;

    //DropCreateDatabaseIfModelChanges<CinemaContext>
    public class ContentInitializer : DropCreateDatabaseAlways<ArtclubContext>
    {
        protected override void Seed(ArtclubContext context)
        {
            var member = new Member().SetIsBoard(true).SetEmail("1028752@ucn.dk").SetGender(false).SetName("Danalachi Sergiu").SetPhone("40789162");
            member.CreateAt = DateTime.UtcNow;

            var artitem = new Artitem().SetArtist("Leon").SetDescription("This is a painting").SetName("Last Supper").SetPurchasePrice(14).SetMinimumBid(50);
            artitem.CreateAt = DateTime.UtcNow;

            context.Members.Add(member);

            context.Artitems.Add(artitem);

            base.Seed(context);
        }
    }
}
