namespace Domain
{
    using System;

    public class Bid
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ArtitemId { get; set; }
        public DateTime CreateAt { get; set; }
        public int Points { get; set; }

        public Member Member { get; set; }
        public Artitem Artitem { get; set; }
        
        public Bid SetCreateAt(DateTime CreateAt)
        {
            this.CreateAt = CreateAt;
            return this;
        }
        public Bid SetPoints(int Points)
        {
            this.Points = Points;
            return this;
        }
        public Bid SetMemberId(int memberId)
        {
            this.MemberId = memberId;
            return this;
        }
       public Bid SetArtItemId(int artitemId)
        {
            this.ArtitemId = artitemId;
            return this;
        }
    }
}
