using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULRIOS
{
    public partial class FRMPORTADA : Form
    {
        public FRMPORTADA()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            FRMPORTADA PORTADA = new FRMPORTADA();
            PORTADA.ShowDialog(); 
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FORMULRIOS.FRMCLIENTES CLIENTE = new FORMULRIOS.FRMCLIENTES();
            CLIENTE.Show(); 
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            FORMULRIOS.FRMEMPLEADOS EMPLEADOS = new FORMULRIOS.FRMEMPLEADOS();
            EMPLEADOS.Show(); 
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
