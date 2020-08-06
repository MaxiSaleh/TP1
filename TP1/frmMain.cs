using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1 {
	public partial class frmMain : Form {

		private string correctUsername = "admin";
		private string correctCarrera = "Sistemas";
		private string correctPassword = "1234";

		public frmMain() {
			InitializeComponent();
			lblWarning.Text = "";
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (txtUsername.Text == correctUsername)
				if (txtPass.Text == correctPassword)
					if (cmbSpecialty.Text == correctCarrera) {
						frmRedes redes = new frmRedes();
						Hide();
						if (redes.ShowDialog() == DialogResult.Cancel)
							Close();
					} else
						lblWarning.Text = "Carrera incorrecta";
				else
					lblWarning.Text = "Contraseña incorrecta";
			else
				lblWarning.Text = "Username incorrecto";
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
