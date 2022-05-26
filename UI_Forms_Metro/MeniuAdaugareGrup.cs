using AdminGrup_FisierNS;
using GrupNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms_Metro
{
    public partial class MeniuAdaugareGrup : Form
    {
        IStocareDateGrup admin_grup;
        
        public MeniuAdaugareGrup()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.CenterToScreen();
            admin_grup = StocareFactoryGrup.GetAdminStocare();
            InitializeComponent();
            this.Text = "Adăugare Grup";
            this.Icon = SystemIcons.Information;

            ButonAdauga.Click += ButonAdauga_click;
            ButonInchide.Click += ButonInchide_click;
        }

        void ButonAdauga_click(object sender, EventArgs e)
        {
            if (ValidareGrup() == false)
            {
                MessageBox.Show("Numele grupului trebuie sa contina cel putini 3 caractere", "Eroare");
                return;
            }
            admin_grup.AddGrup(new Grup(admin_grup.GetGrupuri().Count, tbxNumeGrup.Text));
            this.tbxNumeGrup.Text = string.Empty; 
        }

        void ButonInchide_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidareGrup()
        {
            return tbxNumeGrup.Text.Length > 3;
        }
    }
}
