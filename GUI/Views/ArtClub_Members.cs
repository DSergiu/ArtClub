using Controlller.Classes;
using Controlller.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class ArtClubApp
    {
        private IMemberCtrl _memberCtrl { get; set; }
        public IMemberCtrl MemberCtrl
        {
            get {
                _memberCtrl = _memberCtrl ?? new MemberCtrl();
                return _memberCtrl;
            }
        }

        public void MemberLoad() 
        {
            member_cb_gender.SelectedIndex = 0;
            member_grid.Rows.Clear();

            ICollection<Member> members = MemberCtrl.GetAllMembers();
            foreach(Member member in members)
                AddRow(member);
        }

        private void member_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int)member_grid.Rows[e.RowIndex].Cells[0].Value;
                Member member = MemberCtrl.GetMemberById(index);
                DisplayMember(member);
            }
            catch (Exception) {}
        }

        private void member_btn_update_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(member_tb_id.Text);

            Member member = MemberCtrl.GetMemberById(id);

            if(member == null)
            {
                SetError("Member does not exist in database");
                return;
            }

            try {
                member
                    .SetEmail(member_tb_email.Text)
                    .SetName(member_tb_name.Text)
                    .SetPhone(member_tb_phone.Text)
                    .SetGender(member_cb_gender.SelectedIndex == 0)
                    .SetIsBoard(member_isboard_checkbox.Checked)
                    .SetIsCancelled(member_iscancelled_checkbox.Checked)
                    .SetEmployeeNo((int)member_tb_employee_no.Value);

                MemberCtrl.UpdateMember(member);

                member_grid.Rows.RemoveAt(member_grid.SelectedRows[0].Index);
                AddRow(member);

                member_grid.Rows[member_grid.Rows.Count - 1].Selected = true;

                SetError("The member was successfully updated", false);                
            }
            catch(InvalidMailException){
                SetError("The email is invalid.");
            }
            catch (InvalidNameException)
            {
                SetError("The name is invalid.");
            }
            catch (InvalidPhoneException)
            {
                SetError("The phone is invalid.");
            }
            catch (Exception)
            {
                SetError("An exception occurred.");
            }
        }

        private void member_btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member()
                        .SetEmail(member_tb_email.Text)
                        .SetName(member_tb_name.Text)
                        .SetPhone(member_tb_phone.Text)
                        .SetGender(member_cb_gender.SelectedIndex == 1)
                        .SetIsBoard(member_isboard_checkbox.Checked)
                        .SetIsCancelled(member_iscancelled_checkbox.Checked)
                        .SetEmployeeNo((int)member_tb_employee_no.Value);

                member.Id = MemberCtrl.CreateMember(member);

                AddRow(member);

                SetError("The member was successfully inserted", false);
            }
            catch (InvalidMailException)
            {
                SetError("The email is invalid.");
            }
            catch (InvalidNameException)
            {
                SetError("The name is invalid.");
            }
            catch (InvalidPhoneException)
            {
                SetError("The phone is invalid.");
            }
            catch (Exception)
            {
                SetError("An exception occurred.");
            }
        }

        private void member_btn_clear_Click(object sender, EventArgs e)
        {
            member_tb_id.Text = "";
            member_tb_name.Text = "";
            member_tb_email.Text = "";
            member_tb_phone.Text = "";
            member_cb_gender.SelectedIndex = 0;
            member_iscancelled_checkbox.Checked = false;
            member_isboard_checkbox.Checked = false;
            member_tb_employee_no.Text = "";
            member_tb_createAt.Text = "";
            member_tb_points.Text = "";

            member_btn_add.Visible = true;
            member_btn_update.Visible = false;
        }

        private void DisplayMember(Member member)
        {
            if(member == null)
            {
                SetError("Member does not exist in database");
                return;
            }

            member_btn_add.Visible = false;
            member_btn_update.Visible = true;

            member_tb_id.Text = member.Id.ToString();
            member_tb_name.Text = member.Name;
            member_tb_email.Text = member.Email;
            member_tb_phone.Text = member.Phone;
            member_cb_gender.SelectedIndex = member.Gender ? 0 : 1;
            member_iscancelled_checkbox.Checked = member.IsCancelled;
            member_isboard_checkbox.Checked = member.IsBoard;
            member_tb_employee_no.Text = member.EmployeeNo.ToString();
            member_tb_createAt.Text = member.CreateAt.ToString();
            member_tb_points.Text = member.Points.ToString();

            System.Diagnostics.Debug.WriteLine(member_cb_gender.SelectedIndex);
        }

        

        private void AddRow(Member member)
        {
            SetError("");
            
            var index = member_grid.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)member_grid.Rows[index];
            row.Cells[0].Value = member.Id;
            row.Cells[1].Value = member.Name;
            row.Cells[2].Value = member.Email;
            row.Cells[3].Value = member.Phone;
            row.Cells[4].Value = member.Gender ? 'M' : 'F';
            row.Cells[5].Value = member.EmployeeNo;
            row.Cells[6].Value = member.Points;
            row.Cells[7].Value = member.IsBoard;
            row.Cells[8].Value = member.IsCancelled;
            row.Cells[9].Value = member.CreateAt;
        }
    }
}
