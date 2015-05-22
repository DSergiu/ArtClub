namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Drawing;

    public class Artitem
    {
        public int Id { get; set; }
        public int IdKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Artist { get; set; }
        public byte[] Img { get; set; }
        public int MinimumBid { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime CreateAt { get; set; }

        public ICollection<Bid> Bids { get; set; }

        public Artitem() 
        {
            Bids = new List<Bid>();
        }


        public Artitem SetId(int id)
        {
            this.Id = id;
            return this;
        }
        

        public Artitem SetIdKey(int idKey)
        {
            this.IdKey = idKey;
            return this;
        }
        

        public Artitem SetMinimumBid(int minimumBid)
        {
            this.MinimumBid = minimumBid;
            return this;
        }

        public Artitem SetPurchasePrice(decimal purchasePrice)
        {
            this.PurchasePrice = purchasePrice;
            return this;
        }

        public Artitem SetName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]{2,40}$");
            Match match = regex.Match(name);

            if (!match.Success)
            {
                throw new InvalidNameException();
            }

            this.Name = name;

            return this;
        }

        public Artitem SetDescription(string description)
        {
            if (description.Length > 512)
            {
                throw new TooLongDescriptionException();
            }

            this.Description = description;

            return this;
        }

        public Artitem SetArtist(string artist)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]{2,40}$");
            Match match = regex.Match(artist);

            if (!match.Success)
            {
                throw new InvalidArtistNameException();
            }

            this.Artist = artist;

            return this;
        }



        public byte[] imageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            Image image = Image.FromStream(ms);
            return image;
        }

        public Image GetImg()
        {
            return byteArrayToImage(this.Img);
        }

        public Artitem SetImg(string imagePath)
        {
            if(imagePath == null)
            {
                return this;
            }

            List<String> validExtensions = new List<String>(new String[] { ".png", ".jpg", ".jpeg" });

            Image image;

            if (!validExtensions.Contains(Path.GetExtension(imagePath).ToLower()))
            {
                throw new ImageInvalidException();
            }
            else
            {
                image = Image.FromFile(imagePath);

                this.Img = imageToByteArray(image);
            }
            return this;
        }
    }
}
