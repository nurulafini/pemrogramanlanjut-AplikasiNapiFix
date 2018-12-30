using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AplikasiNapi.Controller;
using AplikasiNapi.Model.Entity;

namespace AplikasiNapi.View
{
    public partial class FrmUtama : Form
    {
        private FrmNarapidana _frmNarapidana;
        private FrmTamu _frmTamu;
        private FrmPetugas _frmPetugas;
        public FrmUtama()
        {
            InitializeComponent();
        }

        private bool IsFormExists(string namaForm)
        {
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name.ToLower() == namaForm.ToLower()) return true;
            }

            return false;
        }

        private void ShowForm(Form frm, string namaForm)
        {
            frm.Name = namaForm;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnNarapidana_Click(object sender, EventArgs e)
        {
            if (!IsFormExists("FrmNarapidana"))
            {
                _frmNarapidana = new FrmNarapidana();
                ShowForm(_frmNarapidana, "FrmNarapidana");
            }
            else
                _frmNarapidana.Activate();
        }

        private void mnTamu_Click(object sender, EventArgs e)
        {
            if (!IsFormExists("FrmTamu"))
            {
                _frmTamu = new FrmTamu();
                ShowForm(_frmTamu, "FrmTamu");
            }
            else
                _frmTamu.Activate();
        }

        private void mnPetugas_Click(object sender, EventArgs e)
        {
            if (!IsFormExists("FrmPetugas"))
            {
                _frmPetugas = new FrmPetugas();
                ShowForm(_frmPetugas, "FrmPetugas");
            }
            else
                _frmPetugas.Activate();
        }

        private void mnTamu2_Click(object sender, EventArgs e)
        {

        }

        private void mnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
