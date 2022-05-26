using AdminGrup_FisierNS;
using AdminPers_FisierNS;
using AdminPersInGrup_FisierNS;
using GrupNS;
using PersInGrupNS;
using PersoanaNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static PersoanaNS.Enumerari;

namespace UI_Forms_Metro
{
    public partial class MeniuAdaugarePers : Form
    {
        private const int OFFSET_X = 592;
        private const int OFFSET_Y = 60;
        private const int SPACE = 30;
        private const int DIM_CONTROLER = 186;
        Persoana persoana;

        public MeniuAdaugarePers(Persoana pers = null, PersInGrup PIG=null)
        {
            persoana = pers;

            //setari form
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.SystemIcons.Information;
            this.Text = "Adăugare / editare persoană";
            this.Name = "Adăugare / editare persoană";

            InitializeComponent();

            //evenimente textbox
            this.tbxNume.GotFocus += tbxNumeGotFocus;
            this.tbxNume.LostFocus += tbxNumeLostFocus;
            this.tbxPrenume.GotFocus += tbxPrenumeGotFocus;
            this.tbxPrenume.LostFocus += tbxPrenumeLostFocus;
            this.tbxEmail.GotFocus += tbxEmailGotFocus;
            this.tbxEmail.LostFocus += tbxEmailLostFocus;
            this.tbxDataN.GotFocus += tbxDataNGotFocus;
            this.tbxDataN.LostFocus += tbxDataNLostFocus;
            this.tbxNrTel.GotFocus += tbxNrTelGotFocus;
            this.tbxNrTel.LostFocus += tbxNrTelLostFocus;
            this.ButonAdauga.Click += ButonAdauga_click;
            this.ButonInchide.Click += ButonInchide_Click;
            this.tbxNume.TextChanged += eventTextBoxNume;
            this.tbxPrenume.TextChanged += eventTextBoxPrenume;
            this.tbxEmail.TextChanged += eventTextBoxEmail;
            this.tbxDataN.TextChanged += eventDataNastere;
            this.tbxNrTel.TextChanged += eventTextBoxNrTel;
            this.ButonModifica.Click += ButonModifica_Click;
     

            IStocareDateGrup adminGrup = StocareFactoryGrup.GetAdminStocare();
            List<Grup> grupuri = adminGrup.GetGrupuri();
            foreach(Grup grup in grupuri)
            {
                listGrupuri.Items.Add(grup.Denumire);
            }


            //setare valori textbox
            if (pers != null)
            {
                tbxNume.Text = pers.Nume;
                tbxPrenume.Text = pers.Prenume;
                tbxDataN.Text = pers.DataN.ToString("dd/MM/yyyy");
                tbxEmail.Text = pers.Email;
                tbxNrTel.Text = pers.NrTel;

                if (pers.SexPers == Sex.M)
                    RBMasculin.Checked = true;
                else RBFeminin.Checked = true;

                if (pers.PasiuniPers.HasFlag(Pasiuni.Sport))
                {
                    ListaPasiuni.SetItemChecked(0, true);
                }

                if (pers.PasiuniPers.HasFlag(Pasiuni.Muzica))
                {
                    ListaPasiuni.SetItemChecked(1, true);
                }

                if (pers.PasiuniPers.HasFlag(Pasiuni.Gaming))
                {
                    ListaPasiuni.SetItemChecked(2, true);
                }

                if(pers.PasiuniPers.HasFlag(Pasiuni.Arta))
                {
                    ListaPasiuni.SetItemChecked(3, true);
                }

                foreach(var item in PIG.idGrupuri)
                {
                   Grup g = adminGrup.GetGrup(item);
                    listGrupuri.SetItemChecked(g.Id, true);
                }
            }
        

        }


        private void ButonInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void eventTextBoxNrTel(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNrTel.Text))
            {
                LabelEroareNrTel.Text = string.Empty;
                LabelNrTel.ForeColor = Color.White;
            }
            else if (!Regex.IsMatch(tbxNrTel.Text, @"^[0-9]+$"))
            {
                LabelEroareNrTel.Text = "Caractere invalide";
                LabelNrTel.ForeColor = Color.Crimson;
            }
            else
            {
                LabelEroareNrTel.Text = string.Empty;
                LabelNrTel.ForeColor = Color.White;
            }
        }


        void eventDataNastere(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDataN.Text))
            {
                LabelEroareDataN.Text = string.Empty;
                LabelDataN.ForeColor = Color.White;
            }
            else
            {
                try
                {
                    Convert.ToDateTime(tbxDataN.Text);
                    LabelEroareDataN.Text = string.Empty;
                    LabelDataN.ForeColor = Color.White;
                }
                catch
                {
                    LabelEroareDataN.Text = "Format data invalid";
                    LabelDataN.ForeColor = Color.Crimson;
                }
            }
        }

        void eventTextBoxEmail(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxEmail.Text))
            {
                LabelEroareEmail.Text = string.Empty;
                LabelEmail.ForeColor = Color.White;
            }
            else
            {
                try
                {
                    var address = new MailAddress(tbxEmail.Text);
                    LabelEroareEmail.Text = string.Empty;
                    LabelEmail.ForeColor = Color.White;
                }
                catch
                {
                    LabelEroareEmail.Text = "Format Email invalid";
                    LabelEmail.ForeColor = Color.Crimson;
                }
            }
        }

        void eventTextBoxNume(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNume.Text))
            {
                LabelEroareNume.Text = string.Empty;
                LabelNume.ForeColor = Color.White;
            }
            else if (!Regex.IsMatch(tbxNume.Text, @"^[a-zA-Z-]+$"))
            {
                LabelEroareNume.Text = "Caractere invalide";
                LabelNume.ForeColor = Color.Crimson;
            }
            else
            {
                LabelEroareNume.Text = string.Empty;
                LabelNume.ForeColor = Color.White;
            }

        }

        void eventTextBoxPrenume(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPrenume.Text))
            {
                LabelEroarePrenume.Text = string.Empty;
                LabelPrenume.ForeColor = Color.White;
            }
            else if (!Regex.IsMatch(tbxPrenume.Text, @"^[a-zA-Z-]+$"))
            {
                LabelEroarePrenume.Text = "Caractere invalide";
                LabelPrenume.ForeColor = Color.Crimson;
            }
            else
            {
                LabelEroarePrenume.Text = string.Empty;
                LabelPrenume.ForeColor = Color.White;
            }

        }

        void tbxNumeGotFocus(object sender, EventArgs e)
        {
            tbxNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            tbxNume.ForeColor = Color.White;
        }

        void tbxNumeLostFocus(object sernder, EventArgs e)
        {
            tbxNume.BackColor = Color.White;
            tbxNume.ForeColor = Color.Black;
        }

        void tbxPrenumeGotFocus(object sender, EventArgs e)
        {
            tbxPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            tbxPrenume.ForeColor = Color.White;
        }

        void tbxPrenumeLostFocus(object sernder, EventArgs e)
        {
            tbxPrenume.BackColor = Color.White;
            tbxPrenume.ForeColor = Color.Black;
        }

        void tbxEmailGotFocus(object sender, EventArgs e)
        {
            tbxEmail.BackColor = this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            tbxEmail.ForeColor = Color.White;
        }

        void tbxEmailLostFocus(object sernder, EventArgs e)
        {
            tbxEmail.BackColor = Color.White;
            tbxEmail.ForeColor = Color.Black;
        }

        void tbxNrTelGotFocus(object sender, EventArgs e)
        {
            tbxNrTel.BackColor = this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            tbxNrTel.ForeColor = Color.White;
        }

        void tbxNrTelLostFocus(object sernder, EventArgs e)
        {
            tbxNrTel.BackColor = Color.White;
            tbxNrTel.ForeColor = Color.Black;
        }

       
        void tbxDataNGotFocus(object sender, EventArgs e)
        {
            tbxDataN.BackColor = this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            tbxDataN.ForeColor = Color.White;
        }

        void tbxDataNLostFocus(object sernder, EventArgs e)
        {
            tbxDataN.BackColor = Color.White;
            tbxDataN.ForeColor = Color.Black;
        }

        private bool VerificareDateEronate()
        {
            return LabelEroareNume.Text.Length > 0
               || LabelEroareEmail.Text.Length > 0
              || LabelEroarePrenume.Text.Length > 0
              || LabelEroareDataN.Text.Length > 0
              || LabelEroareNrTel.Text.Length > 0;
        }

        private bool VerificareDataNeintroduse()
        {
            return (tbxNume.Text == string.Empty
                || tbxPrenume.Text == string.Empty
                || tbxEmail.Text == string.Empty
                || tbxNrTel.Text == string.Empty

                || tbxDataN.Text == string.Empty)
                || (RBFeminin.Checked == false && RBMasculin.Checked == false)
                || ListaPasiuni.CheckedItems.Count.Equals(0)
                || listGrupuri.CheckedItems.Count.Equals(0);
                
        }
         
        private void CuratareTextBoxuri()
        {
            this.tbxNume.Text = string.Empty;
            this.tbxPrenume.Text = string.Empty;
            this.tbxDataN.Text = string.Empty;
            this.tbxNrTel.Text = string.Empty;
     
            this.tbxEmail.Text = string.Empty;
            RBMasculin.Checked = false;
            RBFeminin.Checked = false;

            for(int i=0; i<=listGrupuri.Items.Count-1; i++)
            {
                listGrupuri.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int i = 0; i <= ListaPasiuni.Items.Count - 1; i++)
            {
                ListaPasiuni.SetItemCheckState(i, CheckState.Unchecked);
            }
        }


        private void ButonAdauga_click(object sender, EventArgs e)
        {
            if (VerificareDataNeintroduse() == true)
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Eroare");
                return;
            }
            else if (VerificareDateEronate() == true)
            {
                MessageBox.Show("Introduceti toate datele corect!", "Eroare");
                return;
            }

            IStocareDate admin_pers = StocareFactoryPers.GetAdminStocare();
            Persoana p = new Persoana(admin_pers.GetPersoane().Count, tbxNume.Text, tbxPrenume.Text, Convert.ToDateTime(tbxDataN.Text), tbxEmail.Text, tbxNrTel.Text);
            p.SexPers = GetSexPersoana();
            foreach (var item in ListaPasiuni.CheckedItems)
            {
               p.PasiuniPers |= (Pasiuni)Enum.Parse(typeof(Pasiuni), item.ToString());
            }
            admin_pers.AddPers(p);

            IStocareDatePersInGrup adminPersInGrup = StocareFactoryPersInGrup.GetAdminStocare();
            PersInGrup pig = new PersInGrup(p.Id);
            pig.idGrupuri = GetGrupuri();
            adminPersInGrup.AddPersInGrup(pig);
            

            CuratareTextBoxuri();
        }

       private List<int> GetGrupuri()
       {
            List<int> ids = new List<int>();
            for (int i = 0; i <= (listGrupuri.Items.Count - 1); i++)
            {
                if (listGrupuri.GetItemChecked(i))
                {
                    ids.Add(i);
                }
            }

            return ids;
        }
     
        private Sex GetSexPersoana()
        {
            if (RBMasculin.Checked)
                return Sex.M;

            return Sex.F;
        }



        private void ButonModifica_Click(object sender, EventArgs e)
        {
            if (VerificareDataNeintroduse() == true)
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Eroare");
                return;
            }
            else if (VerificareDateEronate() == true)
            {
                MessageBox.Show("Introduceti toate datele corect!", "Eroare");
                return;
            }

            IStocareDate admin_pers = StocareFactoryPers.GetAdminStocare();
            Persoana Pers=new Persoana(persoana.Id, tbxNume.Text, tbxPrenume.Text, Convert.ToDateTime(tbxDataN.Text), tbxEmail.Text, tbxNrTel.Text);
            Pers.SexPers = GetSexPersoana();
            foreach (var item in ListaPasiuni.CheckedItems)
            {
                Pers.PasiuniPers |= (Pasiuni)Enum.Parse(typeof(Pasiuni), item.ToString());
            }
            admin_pers.UpdatePersoana(Pers);

            IStocareDatePersInGrup adminPersInGrup = StocareFactoryPersInGrup.GetAdminStocare();
            PersInGrup pig = new PersInGrup(Pers.Id);
            pig.idGrupuri = GetGrupuri();
            adminPersInGrup.UpdatePIG(pig);
            CuratareTextBoxuri();
        }

        private void ButonModifica_click(object Snder, EventArgs e)
        {
            if (VerificareDataNeintroduse() == true)
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Eroare");
                return;
            }
            else if (VerificareDateEronate() == true)
            {
                MessageBox.Show("Introduceti toate datele corect!", "Eroare");
                return;
            }

            IStocareDate admin_pers = StocareFactoryPers.GetAdminStocare();
            Persoana p = new Persoana(admin_pers.GetPersoane().Count, tbxNume.Text, tbxPrenume.Text, Convert.ToDateTime(tbxDataN.Text), tbxEmail.Text, tbxNrTel.Text);
            p.SexPers = GetSexPersoana();
            foreach (var item in ListaPasiuni.CheckedItems)
            {
                p.PasiuniPers |= (Pasiuni)Enum.Parse(typeof(Pasiuni), item.ToString());
            }
            admin_pers.UpdatePersoana(p);

            IStocareDatePersInGrup adminPersInGrup = StocareFactoryPersInGrup.GetAdminStocare();
            PersInGrup pig = new PersInGrup(p.Id);
            pig.idGrupuri = GetGrupuri();
            adminPersInGrup.UpdatePIG(pig);
            CuratareTextBoxuri();
        }

    
    }
}
