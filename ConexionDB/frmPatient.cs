using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Patient add = new Patient();

            add.names = label1.Text;
            add.Years = label2.Text;
            add.NumberPhone = txtNumber.Text;
            add.sickNess = txtSick.Text;

            int returne = Function.agregar(add);

            if (returne > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Se han agregado los registros", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se han agregado los registros", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = Function.mostrar();

            txtName.Clear();
            txtYears.Clear();
            txtNumber.Clear();
            txtSick.Clear();

        }
    }
}
