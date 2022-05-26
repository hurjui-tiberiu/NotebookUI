using AdminGrup_FisierNS;
using AdminPers_FisierNS;
using AdminPersInGrup_FisierNS;
using PersInGrupNS;
using PersoanaNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static PersoanaNS.Enumerari;

namespace UI_Forms_Metro
{
    public partial class MeniuAfisare : Form
    {
        List<Persoana> Persoane;
        IStocareDate adminPersoane;

        public MeniuAfisare()
        {
            adminPersoane = StocareFactoryPers.GetAdminStocare();

            InitializeComponent();

            //setare proprietati
            this.Name = "Agendă";
            this.Text = "Agendă";
            this.Icon = SystemIcons.Information;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            GridAgenda.CellContentDoubleClick += dataGridView1_CellContentClick;
            this.ButonCauta.Click += ButonCauta_click;
            this.tbxCautarePrenume.GotFocus += tbxCautarePrenumeFocus;
            this.tbxCautarePrenume.LostFocus += tbxCautarePrenumeLostFocus;
            this.tbxCautareNume.GotFocus += tbxCautareNumeFocus;
            this.tbxCautareNume.LostFocus += tbxCautareNumeLostFocus;

        }

        private void tbxCautareNumeFocus(object sender, EventArgs e)
        {
            this.tbxCautareNume.BackColor = Color.DarkCyan;
            this.tbxCautareNume.ForeColor = Color.White;
        }

        private void tbxCautareNumeLostFocus(object sender, EventArgs e)
        {
            this.tbxCautareNume.BackColor = Color.White;
            this.tbxCautareNume.ForeColor = Color.Black;
        }

        private void tbxCautarePrenumeFocus(object sender, EventArgs e)
        {
            this.tbxCautarePrenume.BackColor = Color.DarkCyan;
            this.tbxCautarePrenume.ForeColor = Color.White;
        }

        private void tbxCautarePrenumeLostFocus(object sender, EventArgs e)
        {
            this.tbxCautarePrenume.BackColor = Color.White;
            this.tbxCautarePrenume.ForeColor = Color.Black;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        private void AfisareStudentiInControlDataGridView()
        {
            GridAgenda.AutoGenerateColumns = false;
            GridAgenda.DataSource = null;
            GridAgenda.DataSource = Persoane;

            IStocareDatePersInGrup adminPersInGrup = StocareFactoryPersInGrup.GetAdminStocare();
            List<PersInGrup> PIG = adminPersInGrup.GetPersInGrup();
            IStocareDateGrup admingrup = StocareFactoryGrup.GetAdminStocare();
            for (int i = 0; i < PIG.Count; i++)
            {
                List<string> lista = new List<string>();
                foreach (var item in PIG[i].idGrupuri)
                {
                    lista.Add(admingrup.GetGrup(item).Denumire);

                }
                string final = string.Join(", ", lista.ToArray());
                GridAgenda.Rows[i].Cells[6].Value = final;

            }

        }

        private void RefreshGrid()
        {
            adminPersoane = StocareFactoryPers.GetAdminStocare();
            Persoane = adminPersoane.GetPersoane();
            AfisareStudentiInControlDataGridView();
        }

        private void ButonAdauga_click(object sender, EventArgs e)
        {
            new MeniuAdaugarePers().ShowDialog();
            RefreshGrid();
        }

        private void ButonRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void LabelAddGrup_Click(object sender, EventArgs e)
        {
            new MeniuAdaugareGrup().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridAgenda.Rows[e.RowIndex];
                Persoana p = adminPersoane.GetPersoane()[Convert.ToInt32(row.Cells[0].Value.ToString())];
               

                IStocareDatePersInGrup adminPersInGrup = StocareFactoryPersInGrup.GetAdminStocare();
                PersInGrup PIG = adminPersInGrup.GetPersInGrup()[Convert.ToInt32(row.Cells[0].Value.ToString())];

                new MeniuAdaugarePers(p, PIG).ShowDialog();

                RefreshGrid();
            }
        }

        private void ButonCauta_click(object sender, EventArgs e)
        {
            listaPersoane.Items.Clear();
          List<Persoana> Pers=  adminPersoane.CautarePersoane (tbxCautareNume.Text, tbxCautarePrenume.Text);
            foreach(var item in Pers)
            {
                listaPersoane.Items.Add(item.ConversieLaSir_PentruFisier);
            }
        }
    }
}
