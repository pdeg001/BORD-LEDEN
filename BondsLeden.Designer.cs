﻿namespace scorebord_leden
{
    partial class BondsLeden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BondsLeden));
            this.chkKnbbSpelers = new System.Windows.Forms.CheckBox();
            this.lstClub = new System.Windows.Forms.ListView();
            this.colNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMember = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewClub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkKnbbSpelers
            // 
            this.chkKnbbSpelers.AutoSize = true;
            this.chkKnbbSpelers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkKnbbSpelers.Location = new System.Drawing.Point(682, 9);
            this.chkKnbbSpelers.Name = "chkKnbbSpelers";
            this.chkKnbbSpelers.Size = new System.Drawing.Size(178, 24);
            this.chkKnbbSpelers.TabIndex = 10;
            this.chkKnbbSpelers.Text = "Verenigings Spelers";
            this.chkKnbbSpelers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKnbbSpelers.UseVisualStyleBackColor = true;
            this.chkKnbbSpelers.CheckedChanged += new System.EventHandler(this.chkKnbbSpelers_CheckedChanged);
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
            this.lstClub.TabIndex = 11;
            this.lstClub.UseCompatibleStateImageBehavior = false;
            this.lstClub.View = System.Windows.Forms.View.Details;
            // 
            // colNaam
            // 
            this.colNaam.Text = "Naam";
            this.colNaam.Width = 271;
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
            this.lstMember.TabIndex = 12;
            this.lstMember.UseCompatibleStateImageBehavior = false;
            this.lstMember.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Naam";
            this.colName.Width = 455;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(671, 584);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(85, 35);
            this.btnDeleteMember.TabIndex = 16;
            this.btnDeleteMember.Text = "Verwijder";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(765, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nieuw &Lid";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(12, 585);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnNewClub
            // 
            this.btnNewClub.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewClub.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClub.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNewClub.Location = new System.Drawing.Point(300, 584);
            this.btnNewClub.Name = "btnNewClub";
            this.btnNewClub.Size = new System.Drawing.Size(85, 35);
            this.btnNewClub.TabIndex = 15;
            this.btnNewClub.Text = "&Nieuw";
            this.btnNewClub.UseVisualStyleBackColor = false;
            // 
            // BondsLeden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 713);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewClub);
            this.Controls.Add(this.lstMember);
            this.Controls.Add(this.lstClub);
            this.Controls.Add(this.chkKnbbSpelers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BondsLeden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonds Leden";
            this.Load += new System.EventHandler(this.BondsLeden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKnbbSpelers;
        private System.Windows.Forms.ListView lstClub;
        private System.Windows.Forms.ColumnHeader colNaam;
        private System.Windows.Forms.ListView lstMember;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewClub;
    }
}