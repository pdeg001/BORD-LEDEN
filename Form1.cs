using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scorebord_leden
{
    public partial class MainForm : Form
    {
        List<ClubModel> vereniging = new List<ClubModel>();
        List<LedenModel> leden = new List<LedenModel>();
        int clubId;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetClubList();
        }

        private void SetClubList()
        {
            lstClub.Items.Clear();
            vereniging = SqliteDataAccess.LoadClubs();

            foreach (var clubList in vereniging)
            {
                var row = new String[] { clubList.Naam };
                var lvi = new ListViewItem(row)
                {
                    Tag = clubList.Id //clubList.Id;
                    
                };
                lstClub.Items.Add(lvi);
            }

            ResizeList(lstClub);
        }




       public void GetListItem(ListView lst)
        {
            if (lst.SelectedItems.Count == 0)
                return;

            ListViewItem item = lst.SelectedItems[0];
            clubId = Int32.Parse(item.Tag.ToString());
            label1.Text = $"SELECTED CLUB ID : {clubId}";//$"ID : {item.Tag} VALUE : {item.Text}";
        }

        private void Lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = sender as ListView;
            GetListItem(lst);
            SetLedenList();
        }


        private void ResizeList(ListView lst)
        {
            lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void BtnNewClub_Click(object sender, EventArgs e)
        {
            ClubModel clubModel = new ClubModel();
            clubModel.Naam = "Naam vereniging";

            SqliteDataAccess.SaveClub(clubModel);
            
            SetClubList();
            lstClub.Refresh();
            int lastItem = lstClub.Items.Count-1;
            lstClub.Items[lastItem].Selected = true;
            lstClub.Select();
            lstClub.EnsureVisible(lastItem);
            lstClub.Items[lastItem].Selected = true;
            lstClub.EnsureVisible(lastItem);
            label1.Text = lastItem.ToString();
            lstClub.Items[lastItem].BeginEdit();
        }

        private void LstClub_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView lst = sender as ListView;
            if (lst.SelectedItems.Count == 0)
                return;

            if (e.Label == null)
                return;

            ListViewItem item = lst.SelectedItems[0];

            label1.Text = $"ID : {item.Tag} VALUE : {item.Text}";
            ClubModel clubModel = new ClubModel();
            clubModel.Id = Int32.Parse(item.Tag.ToString());
            clubModel.Naam = e.Label.ToString();

            SqliteDataAccess.UpdateClub(clubModel);
            SetClubList();
           

         //   label1.Text = e.Label.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ListView lst = lstClub;
            if (lst.SelectedItems.Count == 0)
            {
                return;
            }

            

            //var result = MessageBox.Show("Vereniging verwijderen?\nDit kan niet ongedaan gemaakt worden!", "Vereniging - Leden",
            //                       MessageBoxButtons.YesNo,
            //                        MessageBoxIcon.Question);
            //if(result == DialogResult.No)
            //{
            //    return;
            //}

            ListViewItem item = lst.SelectedItems[0];
            ClubModel clubModel = new ClubModel();
            clubModel.Id = Int32.Parse(item.Tag.ToString());
            clubModel.Naam = item.Text;

            SqliteDataAccess.DeleteClub(clubModel);
            SetClubList();
            GenFunction.SetLvLastItem(lstClub);
           // int lastItem = lstClub.Items.Count - 1;
           // lstClub.Items[lastItem].Selected = true;
           // lstClub.Select();
           // lstClub.EnsureVisible(lastItem);
           
        }

        private void SetLedenList()
        {
            lstMember.Items.Clear();
            LedenModel lm = new LedenModel();
            lm.IdClub = clubId;

            leden = SqliteDataAccess.GetLeden(lm);

            foreach (var ledenList in leden)
            {
                var row = new String[] { ledenList.Name };
                var lvi = new ListViewItem(row)
                {
                    Tag = ledenList.Id //clubList.Id;
                };
                 lstMember.Items.Add(lvi);
            }
        }

        private void NewMember(object sender, MouseEventArgs e)
        {
            LedenModel lm = new LedenModel
            {
                IdClub = clubId,
                Name = "Naam"
            };
            SqliteDataAccess.SaveLeden(lm);
            SetLedenList();
        }

        private void LstMember_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView lst = sender as ListView;
            int index = GenFunction.GetLvIndex(lst);
            Console.WriteLine(index);
            if (lst.SelectedItems.Count == 0)
                return;

            if (e.Label == null)
                return;

            ListViewItem item = lst.SelectedItems[0];

            LedenModel ledenModel = new LedenModel
            {
                Id = Int32.Parse(item.Tag.ToString()),
                Name = e.Label.ToString()
            };

            SqliteDataAccess.UpdateLeden(ledenModel);
            SetLedenList();
            GenFunction.SelectLvCurrentItem(lst, index);

            
        }
    }
}
