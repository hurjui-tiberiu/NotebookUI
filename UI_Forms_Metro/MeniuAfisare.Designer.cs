
namespace UI_Forms_Metro
{
    partial class MeniuAfisare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButonAdauga = new MetroFramework.Controls.MetroButton();
            this.ButonRefresh = new MetroFramework.Controls.MetroButton();
            this.GridAgenda = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNrTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPasiuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelAddGrup = new MetroFramework.Controls.MetroButton();
            this.ButonCauta = new MetroFramework.Controls.MetroButton();
            this.listaPersoane = new System.Windows.Forms.ListBox();
            this.LabelNrTel = new MetroFramework.Controls.MetroLabel();
            this.tbxCautarePrenume = new MetroFramework.Controls.MetroTextBox();
            this.tbxCautareNume = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelAgenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonAdauga
            // 
            this.ButonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.ButonAdauga.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButonAdauga.ForeColor = System.Drawing.Color.White;
            this.ButonAdauga.Location = new System.Drawing.Point(447, 565);
            this.ButonAdauga.Name = "ButonAdauga";
            this.ButonAdauga.Size = new System.Drawing.Size(149, 45);
            this.ButonAdauga.TabIndex = 4;
            this.ButonAdauga.Text = "Adaugă Persoană";
            this.ButonAdauga.UseCustomBackColor = true;
            this.ButonAdauga.UseCustomForeColor = true;
            this.ButonAdauga.UseSelectable = true;
            this.ButonAdauga.Click += new System.EventHandler(this.ButonAdauga_click);
            // 
            // ButonRefresh
            // 
            this.ButonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.ButonRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButonRefresh.Location = new System.Drawing.Point(641, 565);
            this.ButonRefresh.Name = "ButonRefresh";
            this.ButonRefresh.Size = new System.Drawing.Size(149, 45);
            this.ButonRefresh.TabIndex = 5;
            this.ButonRefresh.Text = "Refresh";
            this.ButonRefresh.UseCustomBackColor = true;
            this.ButonRefresh.UseCustomForeColor = true;
            this.ButonRefresh.UseMnemonic = false;
            this.ButonRefresh.UseSelectable = true;
            this.ButonRefresh.Click += new System.EventHandler(this.ButonRefresh_Click);
            // 
            // GridAgenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(185)))), ((int)(((byte)(149)))));
            this.GridAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNume,
            this.ColPrenume,
            this.ColEmail,
            this.ColDataN,
            this.ColNrTel,
            this.ColGrup,
            this.ColSex,
            this.ColPasiuni});
            this.GridAgenda.EnableHeadersVisualStyles = false;
            this.GridAgenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.GridAgenda.Location = new System.Drawing.Point(12, 103);
            this.GridAgenda.Name = "GridAgenda";
            this.GridAgenda.ReadOnly = true;
            this.GridAgenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAgenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridAgenda.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridAgenda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridAgenda.RowTemplate.Height = 24;
            this.GridAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAgenda.Size = new System.Drawing.Size(1400, 437);
            this.GridAgenda.TabIndex = 5;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 40;
            // 
            // ColNume
            // 
            this.ColNume.DataPropertyName = "Nume";
            this.ColNume.HeaderText = "Nume";
            this.ColNume.MinimumWidth = 6;
            this.ColNume.Name = "ColNume";
            this.ColNume.ReadOnly = true;
            this.ColNume.Width = 180;
            // 
            // ColPrenume
            // 
            this.ColPrenume.DataPropertyName = "Prenume";
            this.ColPrenume.HeaderText = "Prenume";
            this.ColPrenume.MinimumWidth = 6;
            this.ColPrenume.Name = "ColPrenume";
            this.ColPrenume.ReadOnly = true;
            this.ColPrenume.Width = 180;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 6;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 180;
            // 
            // ColDataN
            // 
            this.ColDataN.DataPropertyName = "DataN";
            this.ColDataN.HeaderText = "Dată naștere";
            this.ColDataN.MinimumWidth = 6;
            this.ColDataN.Name = "ColDataN";
            this.ColDataN.ReadOnly = true;
            this.ColDataN.Width = 140;
            // 
            // ColNrTel
            // 
            this.ColNrTel.DataPropertyName = "NrTel";
            this.ColNrTel.HeaderText = "Număr tel.";
            this.ColNrTel.MinimumWidth = 6;
            this.ColNrTel.Name = "ColNrTel";
            this.ColNrTel.ReadOnly = true;
            this.ColNrTel.Width = 180;
            // 
            // ColGrup
            // 
            this.ColGrup.DataPropertyName = "Grup";
            this.ColGrup.HeaderText = "Grup";
            this.ColGrup.MinimumWidth = 6;
            this.ColGrup.Name = "ColGrup";
            this.ColGrup.ReadOnly = true;
            this.ColGrup.Width = 180;
            // 
            // ColSex
            // 
            this.ColSex.DataPropertyName = "SexPers";
            this.ColSex.HeaderText = "Sex";
            this.ColSex.MinimumWidth = 6;
            this.ColSex.Name = "ColSex";
            this.ColSex.ReadOnly = true;
            this.ColSex.Width = 40;
            // 
            // ColPasiuni
            // 
            this.ColPasiuni.DataPropertyName = "PasiuniPers";
            this.ColPasiuni.HeaderText = "Pasiuni";
            this.ColPasiuni.MinimumWidth = 6;
            this.ColPasiuni.Name = "ColPasiuni";
            this.ColPasiuni.ReadOnly = true;
            this.ColPasiuni.Width = 200;
            // 
            // LabelAddGrup
            // 
            this.LabelAddGrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.LabelAddGrup.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LabelAddGrup.ForeColor = System.Drawing.Color.White;
            this.LabelAddGrup.Location = new System.Drawing.Point(835, 565);
            this.LabelAddGrup.Name = "LabelAddGrup";
            this.LabelAddGrup.Size = new System.Drawing.Size(149, 45);
            this.LabelAddGrup.TabIndex = 6;
            this.LabelAddGrup.Text = "Adaugă Grup";
            this.LabelAddGrup.UseCustomBackColor = true;
            this.LabelAddGrup.UseCustomForeColor = true;
            this.LabelAddGrup.UseMnemonic = false;
            this.LabelAddGrup.UseSelectable = true;
            this.LabelAddGrup.Click += new System.EventHandler(this.LabelAddGrup_Click);
            // 
            // ButonCauta
            // 
            this.ButonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.ButonCauta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButonCauta.ForeColor = System.Drawing.Color.White;
            this.ButonCauta.Location = new System.Drawing.Point(282, 9);
            this.ButonCauta.Name = "ButonCauta";
            this.ButonCauta.Size = new System.Drawing.Size(123, 52);
            this.ButonCauta.TabIndex = 3;
            this.ButonCauta.Text = "Caută Persoană";
            this.ButonCauta.UseCustomBackColor = true;
            this.ButonCauta.UseCustomForeColor = true;
            this.ButonCauta.UseSelectable = true;
            // 
            // listaPersoane
            // 
            this.listaPersoane.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPersoane.FormattingEnabled = true;
            this.listaPersoane.ItemHeight = 15;
            this.listaPersoane.Location = new System.Drawing.Point(12, 66);
            this.listaPersoane.Name = "listaPersoane";
            this.listaPersoane.Size = new System.Drawing.Size(393, 34);
            this.listaPersoane.TabIndex = 20;
            // 
            // LabelNrTel
            // 
            this.LabelNrTel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelNrTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.LabelNrTel.Location = new System.Drawing.Point(12, 38);
            this.LabelNrTel.Margin = new System.Windows.Forms.Padding(0);
            this.LabelNrTel.Name = "LabelNrTel";
            this.LabelNrTel.Size = new System.Drawing.Size(90, 22);
            this.LabelNrTel.TabIndex = 19;
            this.LabelNrTel.Text = "Prenume";
            this.LabelNrTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelNrTel.UseCustomBackColor = true;
            this.LabelNrTel.UseCustomForeColor = true;
            // 
            // tbxCautarePrenume
            // 
            this.tbxCautarePrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.tbxCautarePrenume.CustomButton.Image = null;
            this.tbxCautarePrenume.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.tbxCautarePrenume.CustomButton.Name = "";
            this.tbxCautarePrenume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCautarePrenume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCautarePrenume.CustomButton.TabIndex = 1;
            this.tbxCautarePrenume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCautarePrenume.CustomButton.UseSelectable = true;
            this.tbxCautarePrenume.CustomButton.Visible = false;
            this.tbxCautarePrenume.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbxCautarePrenume.ForeColor = System.Drawing.Color.Gray;
            this.tbxCautarePrenume.Lines = new string[0];
            this.tbxCautarePrenume.Location = new System.Drawing.Point(105, 38);
            this.tbxCautarePrenume.MaxLength = 16;
            this.tbxCautarePrenume.Name = "tbxCautarePrenume";
            this.tbxCautarePrenume.PasswordChar = '\0';
            this.tbxCautarePrenume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCautarePrenume.SelectedText = "";
            this.tbxCautarePrenume.SelectionLength = 0;
            this.tbxCautarePrenume.SelectionStart = 0;
            this.tbxCautarePrenume.ShortcutsEnabled = true;
            this.tbxCautarePrenume.Size = new System.Drawing.Size(171, 23);
            this.tbxCautarePrenume.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCautarePrenume.TabIndex = 2;
            this.tbxCautarePrenume.UseCustomBackColor = true;
            this.tbxCautarePrenume.UseCustomForeColor = true;
            this.tbxCautarePrenume.UseSelectable = true;
            this.tbxCautarePrenume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCautarePrenume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbxCautareNume
            // 
            this.tbxCautareNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            // 
            // 
            // 
            this.tbxCautareNume.CustomButton.Image = null;
            this.tbxCautareNume.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.tbxCautareNume.CustomButton.Name = "";
            this.tbxCautareNume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCautareNume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCautareNume.CustomButton.TabIndex = 1;
            this.tbxCautareNume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCautareNume.CustomButton.UseSelectable = true;
            this.tbxCautareNume.CustomButton.Visible = false;
            this.tbxCautareNume.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbxCautareNume.ForeColor = System.Drawing.Color.Gray;
            this.tbxCautareNume.Lines = new string[0];
            this.tbxCautareNume.Location = new System.Drawing.Point(105, 9);
            this.tbxCautareNume.MaxLength = 16;
            this.tbxCautareNume.Name = "tbxCautareNume";
            this.tbxCautareNume.PasswordChar = '\0';
            this.tbxCautareNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCautareNume.SelectedText = "";
            this.tbxCautareNume.SelectionLength = 0;
            this.tbxCautareNume.SelectionStart = 0;
            this.tbxCautareNume.ShortcutsEnabled = true;
            this.tbxCautareNume.Size = new System.Drawing.Size(171, 23);
            this.tbxCautareNume.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCautareNume.TabIndex = 1;
            this.tbxCautareNume.UseCustomBackColor = true;
            this.tbxCautareNume.UseCustomForeColor = true;
            this.tbxCautareNume.UseSelectable = true;
            this.tbxCautareNume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCautareNume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.metroLabel1.Location = new System.Drawing.Point(12, 9);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 22);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Nume";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // labelAgenda
            // 
            this.labelAgenda.AutoSize = true;
            this.labelAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.labelAgenda.Location = new System.Drawing.Point(609, 38);
            this.labelAgenda.Name = "labelAgenda";
            this.labelAgenda.Size = new System.Drawing.Size(214, 52);
            this.labelAgenda.TabIndex = 24;
            this.labelAgenda.Text = "AGENDĂ";
            // 
            // MeniuAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1424, 641);
            this.Controls.Add(this.labelAgenda);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbxCautareNume);
            this.Controls.Add(this.ButonCauta);
            this.Controls.Add(this.listaPersoane);
            this.Controls.Add(this.LabelNrTel);
            this.Controls.Add(this.tbxCautarePrenume);
            this.Controls.Add(this.LabelAddGrup);
            this.Controls.Add(this.GridAgenda);
            this.Controls.Add(this.ButonRefresh);
            this.Controls.Add(this.ButonAdauga);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MeniuAfisare";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton ButonAdauga;
        private MetroFramework.Controls.MetroButton ButonRefresh;
        private System.Windows.Forms.DataGridView GridAgenda;
        private MetroFramework.Controls.MetroButton LabelAddGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNrTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPasiuni;
        private MetroFramework.Controls.MetroButton ButonCauta;
        private System.Windows.Forms.ListBox listaPersoane;
        private MetroFramework.Controls.MetroLabel LabelNrTel;
        private MetroFramework.Controls.MetroTextBox tbxCautarePrenume;
        private MetroFramework.Controls.MetroTextBox tbxCautareNume;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label labelAgenda;
    }
}