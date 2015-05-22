using Controlller.Classes;
using Controlller.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class ArtClubApp
    {
        private IArtitemCtrl _artitemCtrl { get; set; }
        public IArtitemCtrl artitemCtrl
        {
            get {
                _artitemCtrl = _artitemCtrl ?? new ArtitemCtrl();
                return _artitemCtrl;
            }
        }

        private string imagePath;

        public void ArtitemLoad() 
        {
            artitem_grid.Rows.Clear();

            ICollection<Artitem> artitems = artitemCtrl.GetAllArtitems();
            foreach(Artitem artitem in artitems)
                AddRow(artitem);

        }

        private Artitem selectedArt;

        private void artitem_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int)artitem_grid.Rows[e.RowIndex].Cells[0].Value;
                Artitem artitem = artitemCtrl.GetArtitemByIdKey(index);
                DisplayArtitem(artitem);
            }
            catch (Exception) {
            }
        }

        private void artitem_btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var artitem = artitemCtrl.GetArtitemById(selectedArt.Id);

                artitem
                    .SetIdKey(Int32.Parse(artitem_tb_id.Text))
                    .SetName(artitem_tb_name.Text)
                    .SetArtist(artitem_tb_artist.Text)
                    .SetDescription(artitem_rtb_description.Text)
                    .SetPurchasePrice(Decimal.Parse(artitem_tb_purchasePrice.Text))
                    .SetMinimumBid(Int32.Parse(artitem_tb_minimumBid.Text))
                    .SetImg(imagePath);


                artitemCtrl.UpdateArtitem(artitem);
                artitem_grid.Rows.RemoveAt(artitem_grid.SelectedRows[0].Index);
                
                AddRow(artitem);

                artitem_grid.Rows[artitem_grid.Rows.Count - 1].Selected = true;

                SetError("The artitem was successfully updated", false);
            }
            catch (InvalidNameException)
            {
                SetError("The name is invalid.");
            }
            catch (InvalidArtistNameException)
            {
                SetError("The artist name is invalid.");
            }
            catch (InvalidMinimumBidException)
            {
                SetError("The minimum bid is invalid.");
            }
            catch (TooLongDescriptionException)
            {
                SetError("The description is too long");
            }
            catch (SameArtItemIdException)
            {
                SetError("This id already exists");
            }
            catch (ArtItemNotInRangeException)
            {
                SetError("This id should have 4 digits");
            }
            catch (FormatException)
            {
                SetError("This purchase price and the minimum bid must be a number");
            }
        }

        private void artitem_btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Artitem artitem = new Artitem()
                    .SetIdKey(Int32.Parse(artitem_tb_id.Text))
                    .SetName(artitem_tb_name.Text)
                    .SetArtist(artitem_tb_artist.Text)
                    .SetDescription(artitem_rtb_description.Text)
                    .SetMinimumBid(Int32.Parse(artitem_tb_minimumBid.Text))
                    .SetPurchasePrice(Decimal.Parse(artitem_tb_purchasePrice.Text))
                    .SetImg(imagePath);

                artitem.Id = artitemCtrl.CreateArtitem(artitem);

                AddRow(artitem);

                SetError("The artitem was successfully inserted", false);
            }
            catch (InvalidNameException)
            {
                SetError("The name is invalid.");
            }
            catch (InvalidMinimumBidException)
            {
                SetError("The minimum bid is invalid.");
            }
            catch (InvalidArtistNameException)
            {
                SetError("The artist name is invalid.");
            }
            catch (TooLongDescriptionException)
            {
                SetError("The description is too long.");
            }
            catch (SameArtItemIdException)
            {
                SetError("This id already exists");
            }
            catch (FormatException)
            {
                SetError("This purchase price and the minimum bid must be a number");
            }
            catch (ImageInvalidException)
            {
                SetError("Invalid image extension (Valid: .jpg, .jpeg, .png)");
            }
            catch (Exception ex)
            {
                SetError("An exception occurred."+ex.GetType());
            }
        }

        private void artitem_btn_clear_Click(object sender, EventArgs e)
        {
            artitem_tb_id.Text = "";
            artitem_tb_name.Text = "";
            artitem_tb_createAt.Text = "";
            artitem_tb_minimumBid.Text = "";
            artitem_tb_purchasePrice.Text = "";
            artitem_tb_artist.Text = "";
            artitem_rtb_description.Text = "";
           

            artitem_btn_add.Visible = true;
            artitem_btn_update.Visible = false;

            selectedArt = null;
        }

        private void artitem_btn_uploadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            fileDialog.FilterIndex = 1;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = fileDialog.FileName;
                try
                {
                    artitem_pb_image.Image = Image.FromFile(imagePath);
                }
                catch (Exception) {
                    SetError("Invalid image");
                }
                
            }
            else
            {
                imagePath = "";
            }
        }

        private void DisplayArtitem(Artitem artitem)
        {
            if(artitem == null)
            {
                SetError("Artitem does not exist in database");
                selectedArt = null;
                return;
            }

            selectedArt = artitem;

            artitem_btn_add.Visible = false;
            artitem_btn_update.Visible = true;

            artitem_tb_id.Text = artitem.IdKey.ToString();
            artitem_tb_name.Text = artitem.Name;
            artitem_tb_createAt.Text = artitem.CreateAt.ToString();
            artitem_tb_artist.Text = artitem.Artist;
            artitem_rtb_description.Text = artitem.Description;
            artitem_tb_minimumBid.Text = artitem.MinimumBid.ToString();
            artitem_tb_purchasePrice.Text = artitem.PurchasePrice.ToString();

            try
            {
                artitem_pb_image.Image = artitem.GetImg();
            }
            catch{}
        }

        

        private void AddRow(Artitem artitem)
        {
            SetError("");
            
            var index = artitem_grid.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)artitem_grid.Rows[index];
            row.Cells[0].Value = artitem.IdKey;
            row.Cells[1].Value = artitem.Name;
            row.Cells[2].Value = artitem.Artist;
            row.Cells[3].Value = artitem.PurchasePrice;
            row.Cells[4].Value = artitem.MinimumBid;
            row.Cells[5].Value = artitem.CreateAt;
        }
    }
}
