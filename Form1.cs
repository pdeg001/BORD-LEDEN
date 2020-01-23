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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            lstClub.Items.Clear();
            lstMember.Items.Clear();
            var club = GetClubList();
            foreach(var clubList in club)
            {
                var row = new String[] { clubList.ClubName};
                var lvi = new ListViewItem(row);
                lvi.Tag = "wdwd"; //clubList.Id;
                lstClub.Items.Add(lvi);
            }

            var member = GetClubMember();
            foreach (var mem in member)
            {
                var row = new String[] { mem.FirstName, mem.LastName };
                var lvi = new ListViewItem(row);
                lvi.Tag = "wdwd"; //clubList.Id;
                lstMember.Items.Add(lvi);
            }

           
            ResizeList(lstMember);
            ResizeList(lstClub);
        }

        private List<Clubs> GetClubList()
        {
            var list = new List<Clubs>();
            list.Add(new Clubs() { ClubName = "bv Heerhugowaard" });
            list.Add(new Clubs() { ClubName = "3bv Parelhof" });

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
      
    }
}
