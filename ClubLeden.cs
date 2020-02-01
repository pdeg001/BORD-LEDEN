using Newtonsoft.Json;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO : GEN GENERIC MESSAGEBOX

namespace scorebord_leden
{
    public partial class MainForm : Form
    {
        List<ClubModel> vereniging = new List<ClubModel>();
        List<LedenModel> leden = new List<LedenModel>();
        int clubId;
        public static MessageBoxManager MessageBoxManager = new MessageBoxManager();
        Boolean btnClosed = false;

        public MainForm()
        {
            InitializeComponent();
            CheckForUpdate();
          //  AddVersionNumber();
        }

        private async Task CheckForUpdate()
        {
            using (var manager = new UpdateManager(@"L:\GITHUB"))
            {
                await manager.UpdateApp();
            }
        }
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetMbm();
            SetClubList();
            GenFunction.SetLvFirstRow(lstClub);
            this.Text += GenFunction.GetVersionNumber();
        }

        private void SetMbm()
        {
            MessageBoxManager.Yes = "Ja";
            MessageBoxManager.No = "Nee";
            MessageBoxManager.Cancel = "Annuleer";
            MessageBoxManager.Register();
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
            lstClub.Columns[0].Width = -2;
            //lstClub.Columns[1].Width = 75;
        }




        public void GetListItem(ListView lst)
        {
            if (lst.SelectedItems.Count == 0)
                return;

            ListViewItem item = lst.SelectedItems[0];
            clubId = Int32.Parse(item.Tag.ToString());
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
            CreateNewClub();
        }

        private void CreateNewClub()
        {
            ClubModel clubModel = new ClubModel();
            clubModel.Naam = "Naam vereniging";

            SqliteDataAccess.SaveClub(clubModel);

            SetClubList();
            lstClub.Refresh();

            GenFunction.SetLvEditAfterNew(lstClub);
        }

        private void LstClub_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView lst = sender as ListView;
            if (lst.SelectedItems.Count == 0)
                return;

            if (e.Label == null)
                return;

            ListViewItem item = lst.SelectedItems[0];

            ClubModel clubModel = new ClubModel();
            clubModel.Id = Int32.Parse(item.Tag.ToString());
            clubModel.Naam = e.Label.ToString();

            SqliteDataAccess.UpdateClub(clubModel);
            SetClubList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ListView lstMem = lstMember;
            if (lstMember.Items.Count > 0)
            {
                MessageBox.Show("Kan vereniging niet verwijderen\nVerwijder eerste de leden", "Vereniging - Leden",
                                  MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                return;
            }
            var result = MessageBox.Show("Vereniging verwijderen?\nDit kan niet ongedaan gemaakt worden!", "Vereniging - Leden",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            ListView lst = lstClub;
            int index = GenFunction.GetLvIndex(lst);
            if (lst.SelectedItems.Count == 0)
            {
                return;
            }


//#if DEBUG == false
           
//            var result = MessageBox.Show("Vereniging verwijderen?\nDit kan niet ongedaan gemaakt worden!", "Vereniging - Leden",
//                                   MessageBoxButtons.YesNo,
//                                    MessageBoxIcon.Question);
//            if(result == DialogResult.No)
//            {
//                return;
//            }
//#endif
            ListViewItem item = lst.SelectedItems[0];
            ClubModel clubModel = new ClubModel();
            clubModel.Id = Int32.Parse(item.Tag.ToString());
            clubModel.Naam = item.Text;

            SqliteDataAccess.DeleteClub(clubModel);
            lst.Items[GenFunction.GetLvIndex(lst)].Remove();
            GenFunction.GetLvPervIndexAfterDelete(lst, index);
            // SetClubList();
            // GenFunction.SetLvLastItem(lstClub);
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
            CreateNewMember();
        }

        private void CreateNewMember()
        {
            LedenModel lm = new LedenModel
            {
                IdClub = clubId,
                Name = "Naam"
            };
            SqliteDataAccess.SaveLeden(lm);
            SetLedenList();
            GenFunction.SetLvEditAfterNew(lstMember);
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

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            ListView lst = lstMember;
            int index = GenFunction.GetLvIndex(lst);
            if (lst.SelectedItems.Count == 0)
                return;

            //#if DEBUG == false
            var result = MessageBox.Show("Verenigingslid verwijderen?\nDit kan niet ongedaan gemaakt worden!", "Vereniging - Leden",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            //#endif


            ListViewItem item = lst.SelectedItems[0];

            LedenModel ledenModel = new LedenModel();
            ledenModel.Id = Int32.Parse(item.Tag.ToString());
            ledenModel.Name = item.Text;

            SqliteDataAccess.DeleteMember(ledenModel);

            lst.Items[GenFunction.GetLvIndex(lst)].Remove();
            GenFunction.GetLvPervIndexAfterDelete(lst, index);
        }

        private void AskCloseApplication()
        {
            var result = MessageBox.Show("Applicatie sluiten", "Vereniging - Leden",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                btnClosed = true;
                Application.Exit();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Alt == true)
                CreateNewClub();
            if (e.KeyCode == Keys.L && e.Alt == true)
                CreateNewMember();
            if (e.KeyCode == Keys.S && e.Alt == true)
                AskCloseApplication();
        }





        private void CopyDb()
        {
            string fileName = "bord_leden.db";
            string dstFolder = GenFunction.SelectFolder();
            string srcFolder = AppDomain.CurrentDomain.BaseDirectory;
#if DEBUG
            srcFolder += @"\" + fileName;
#else
            srcFolder += fileName;
#endif
            dstFolder += @"\" + fileName;

            System.IO.File.Copy(srcFolder, dstFolder, true);

            if (System.IO.File.Exists(dstFolder) == true)
                MessageBox.Show("Database gekopieerd", "Vereniging - Leden",
                                  MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            else
                MessageBox.Show("Database niet gekopieerd", "Vereniging - Leden",
                                  MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
        }

        private void BtnCopyDb_MouseUp(object sender, MouseEventArgs e)
        {
            CopyDb();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            AskCloseApplication();
        }

        private void GenerateVerJson()
        {
            string clubName;
            int clubId;
            Boolean err;

            string path = GenFunction.SelectFolder();
            if (path == "" || path == null)
                return;

            path += @"\";
            try
            {
                for (int i = 0; i < lstClub.Items.Count; i++)
                {
                    ListViewItem item = lstClub.Items[i];
                    clubName = item.Text;
                    clubId = Int32.Parse(item.Tag.ToString()); ;

                    err = GenJsonFile(clubId, clubName, path);
                    if (err)
                    {
                        Console.WriteLine("Err");
                        return;
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Vereniging - Leden",
                                  MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }

            _ = MessageBox.Show("Bestanden gegenereerd", "Vereniging - Leden",
                              MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
        }

        private Boolean GenJsonFile(int clubId, string clubName, string path)
        {
            DataSet dataSet = new DataSet("dataSet");
            dataSet.Namespace = "NetFrameWork";
            DataTable table = new DataTable();
            table.TableName = clubName;

            DataColumn itemColumn = new DataColumn("name");

            table.Columns.Add(itemColumn);
            dataSet.Tables.Add(table);

            LedenModel lm = new LedenModel();
            lm.IdClub = clubId;

            leden = SqliteDataAccess.GetLeden(lm);

            foreach (var ledenList in leden)
            {
                DataRow newRow = table.NewRow();
                newRow["name"] = ledenList.Name;
                table.Rows.Add(newRow);
            }

            dataSet.AcceptChanges();
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);

            try
            {

                using (var tw = new StreamWriter($@"{path}\{clubName}.json", false))
                {
                    tw.WriteLine(json);
                    tw.Close();
                }
                return false;
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message, "Vereniging - Leden",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return true;
            }
            finally
            {
            }
            Console.WriteLine(json);
        }

        private void BtnCopyDb_Click(object sender, EventArgs e)
        {
            GenerateVerJson();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnClosed == true)
                return;

            var result = MessageBox.Show("Applicatie sluiten", "Vereniging - Leden",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

            e.Cancel = result == DialogResult.No;
        }

        public void chkKnbbSpelers_CheckedChanged(object sender, EventArgs e)
        {
            
                
            BondsLeden knbbSpelers = new BondsLeden();

            knbbSpelers.Location = this.Location;
            //knbbSpelers.Top = this.Top;
            //knbbSpelers.Left = this.Left;
            //knbbSpelers.Height = this.Height;
            //knbbSpelers.Width = this.Width;
            knbbSpelers.Show();
            MessageBoxManager.Unregister();
            this.Hide();
        }

        public void ShowVereniging()
        {
            
            Opacity = 100;
        }

    }
}
