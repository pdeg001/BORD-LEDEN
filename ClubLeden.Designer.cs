namespace scorebord_leden
{
    partial class ClubLeden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubLeden));
            this.lstClub = new System.Windows.Forms.ListView();
            this.colNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lstMember = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewClub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.BtnCopyDb = new System.Windows.Forms.Button();
            this.chkKnbbSpelers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstClub
            // 
            this.lstClub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNaam});
            this.lstClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClub.FullRowSelect = true;
            this.lstClub.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstClub.HideSelection = false;
            this.lstClub.LabelEdit = true;
            this.lstClub.LabelWrap = false;
            this.lstClub.Location = new System.Drawing.Point(12, 35);
            this.lstClub.MultiSelect = false;
            this.lstClub.Name = "lstClub";
            this.lstClub.Size = new System.Drawing.Size(373, 544);
            this.lstClub.TabIndex = 0;
            this.lstClub.UseCompatibleStateImageBehavior = false;
            this.lstClub.View = System.Windows.Forms.View.Details;
            this.lstClub.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LstClub_AfterLabelEdit);
            this.lstClub.SelectedIndexChanged += new System.EventHandler(this.Lst_SelectedIndexChanged);
            // 
            // colNaam
            // 
            this.colNaam.Text = "Naam";
            this.colNaam.Width = 271;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vereniging";
            // 
            // lstMember
            // 
            this.lstMember.BackColor = System.Drawing.SystemColors.Window;
            this.lstMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lstMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMember.FullRowSelect = true;
            this.lstMember.HideSelection = false;
            this.lstMember.LabelEdit = true;
            this.lstMember.LabelWrap = false;
            this.lstMember.Location = new System.Drawing.Point(391, 35);
            this.lstMember.MultiSelect = false;
            this.lstMember.Name = "lstMember";
            this.lstMember.Size = new System.Drawing.Size(459, 544);
            this.lstMember.TabIndex = 3;
            this.lstMember.UseCompatibleStateImageBehavior = false;
            this.lstMember.View = System.Windows.Forms.View.Details;
            this.lstMember.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LstMember_AfterLabelEdit);
            // 
            // colName
            // 
            this.colName.Text = "Naam";
            this.colName.Width = 455;
            // 
            // btnNewClub
            // 
            this.btnNewClub.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewClub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewClub.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnNewClub.Location = new System.Drawing.Point(300, 584);
            this.btnNewClub.Name = "btnNewClub";
            this.btnNewClub.Size = new System.Drawing.Size(85, 35);
            this.btnNewClub.TabIndex = 4;
            this.btnNewClub.Text = "&Nieuw";
            this.btnNewClub.UseVisualStyleBackColor = false;
            this.btnNewClub.Click += new System.EventHandler(this.BtnNewClub_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.button1.Location = new System.Drawing.Point(765, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nieuw &Lid";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewMember);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnDelete.Location = new System.Drawing.Point(12, 585);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnDeleteMember.Location = new System.Drawing.Point(671, 584);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(85, 35);
            this.btnDeleteMember.TabIndex = 6;
            this.btnDeleteMember.Text = "Verwijder";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leden";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnCloseApp.Location = new System.Drawing.Point(765, 654);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(85, 35);
            this.btnCloseApp.TabIndex = 7;
            this.btnCloseApp.Text = "Af&sluiten";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // BtnCopyDb
            // 
            this.BtnCopyDb.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnCopyDb.Location = new System.Drawing.Point(12, 654);
            this.BtnCopyDb.Name = "BtnCopyDb";
            this.BtnCopyDb.Size = new System.Drawing.Size(190, 35);
            this.BtnCopyDb.TabIndex = 8;
            this.BtnCopyDb.Text = "Genereer data bestanden";
            this.BtnCopyDb.UseVisualStyleBackColor = true;
            this.BtnCopyDb.Click += new System.EventHandler(this.BtnCopyDb_Click);
            // 
            // chkKnbbSpelers
            // 
            this.chkKnbbSpelers.AutoSize = true;
            this.chkKnbbSpelers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkKnbbSpelers.Location = new System.Drawing.Point(682, 9);
            this.chkKnbbSpelers.Name = "chkKnbbSpelers";
            this.chkKnbbSpelers.Size = new System.Drawing.Size(137, 24);
            this.chkKnbbSpelers.TabIndex = 9;
            this.chkKnbbSpelers.Text = "KNBB Spelers";
            this.chkKnbbSpelers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKnbbSpelers.UseVisualStyleBackColor = true;
            this.chkKnbbSpelers.CheckedChanged += new System.EventHandler(this.chkKnbbSpelers_CheckedChanged);
            // 
            // ClubLeden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 713);
            this.Controls.Add(this.chkKnbbSpelers);
            this.Controls.Add(this.BtnCopyDb);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewClub);
            this.Controls.Add(this.lstMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstClub);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ClubLeden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Leden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstClub;
        private System.Windows.Forms.ColumnHeader colNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstMember;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnNewClub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button BtnCopyDb;
        private System.Windows.Forms.CheckBox chkKnbbSpelers;
    }
}

