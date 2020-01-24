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
        List<Clubs> vereniging = new List<Clubs>();
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            SetClubList();

            //lstClub.Items.Clear();
            //lstMember.Items.Clear();
            //vereniging = SqliteDataAccess.LoadClubs();
            
            //var club = GetClubList();
            //foreach(var clubList in vereniging)
            //{
            //    var row = new String[] { clubList.Naam};
            //    var lvi = new ListViewItem(row);
            //    lvi.Tag = clubList.Id; //clubList.Id;
            //    lstClub.Items.Add(lvi);
            //}

            //var member = GetClubMember();
            //foreach (var mem in member)
            //{
            //    var row = new String[] { mem.FirstName, mem.LastName };
            //    var lvi = new ListViewItem(row);
            //    lvi.Tag = "wdwd"; //clubList.Id;
            //    lstMember.Items.Add(lvi);
            //}
            
           
            // ResizeList(lstMember);
            //ResizeList(lstClub);
        }

        private void SetClubList()
        {
            lstClub.Items.Clear();
            vereniging = SqliteDataAccess.LoadClubs();

            //var club = GetClubList();
            foreach (var clubList in vereniging)
            {
                var row = new String[] { clubList.Naam };
                var lvi = new ListViewItem(row);
                lvi.Tag = clubList.Id; //clubList.Id;
                lstClub.Items.Add(lvi);
            }

            ResizeList(lstClub);
        }


        private List<Clubs> GetClubList()
        {
            var list = new List<Clubs>();
            list.Add(new Clubs() { Naam = "bv Heerhugowaard" });
            list.Add(new Clubs() { Naam = "3bv Parelhof" });

            return list;
        }


        private List<People> GetClubMember()
        {
            var list = new List<People>();
            list.Add(new People() { Id = "100", FirstName = "Peter", LastName = "de Groot", ClubId = "1" });
            list.Add(new People() { Id = "100", FirstName = "Peter", LastName = "de Groot", ClubId = "1" });
            list.Add(new People() { Id = "100", FirstName = "Peter", LastName = "de Groot", ClubId = "1" });
            list.Add(new People() { Id = "100", FirstName = "Peter", LastName = "de Groot", ClubId = "1" });
            list.Add(new People() { Id = "100", FirstName = "Peterewfwefwefwefwefwefwe", LastName = "de Groot", ClubId = "1" });

            return list;
        }


       public void GetListItem(ListView lst)
        {
            if (lst.SelectedItems.Count == 0)
                return;

            ListViewItem item = lst.SelectedItems[0];

            label1.Text = $"ID : {item.Tag} VALUE : {item.Text}";
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = sender as ListView;
            GetListItem(lst);
        }


        private void ResizeList(ListView lst)
        {
            lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            Clubs clubModel = new Clubs();
            clubModel.Naam = "";

            SqliteDataAccess.SaveClub(clubModel);
            SetClubList();
        }
    }
}
