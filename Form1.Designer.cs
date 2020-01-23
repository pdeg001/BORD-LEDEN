namespace scorebord_leden
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstClub = new System.Windows.Forms.ListView();
            this.colNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstMember = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstClub
            // 
            this.lstClub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNaam});
            this.lstClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClub.FullRowSelect = true;
            this.lstClub.HideSelection = false;
            this.lstClub.LabelEdit = true;
            this.lstClub.LabelWrap = false;
            this.lstClub.Location = new System.Drawing.Point(12, 35);
            this.lstClub.MultiSelect = false;
            this.lstClub.Name = "lstClub";
            this.lstClub.Size = new System.Drawing.Size(373, 544);
            this.lstClub.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstClub.TabIndex = 0;
            this.lstClub.UseCompatibleStateImageBehavior = false;
            this.lstClub.View = System.Windows.Forms.View.Details;
            this.lstClub.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // colNaam
            // 
            this.colNaam.Text = "Naam";
            this.colNaam.Width = 313;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vereniging";
            // 
            // lstMember
            // 
            this.lstMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName});
            this.lstMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMember.FullRowSelect = true;
            this.lstMember.HideSelection = false;
            this.lstMember.LabelEdit = true;
            this.lstMember.LabelWrap = false;
            this.lstMember.Location = new System.Drawing.Point(391, 35);
            this.lstMember.MultiSelect = false;
            this.lstMember.Name = "lstMember";
            this.lstMember.Size = new System.Drawing.Size(459, 544);
            this.lstMember.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstMember.TabIndex = 3;
            this.lstMember.UseCompatibleStateImageBehavior = false;
            this.lstMember.View = System.Windows.Forms.View.Details;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "Naam";
            this.colFirstName.Width = 54;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Achternaam";
            this.colLastName.Width = 253;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 657);
            this.Controls.Add(this.lstMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClub);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Leden";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstClub;
        private System.Windows.Forms.ColumnHeader colNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstMember;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
    }
}

