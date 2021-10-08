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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            string conectionString = "";
            MySqlConnection con;

            try
            {
                // definir string de conexion
                conectionString = @"Server=localhost;Databade=SMIS006121; Uid=root;
                Pwd=usbw;SSL Mode=None";//definimos string de conexion
                con = new MySqlConnection(conectionString);//creamos la conexion
                con.Open();//abrimos la conexion a la base de datos
                MetroFramework.MetroMessageBox.Show(this, "Se establecio la conexion!", "TEST",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "EXCEPCION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }
    }
}
