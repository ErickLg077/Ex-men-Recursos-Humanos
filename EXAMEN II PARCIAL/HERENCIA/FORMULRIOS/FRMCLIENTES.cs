﻿using System;
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
    public partial class FRMCLIENTES : Form
    {
        public FRMCLIENTES()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.CLIENTE CLIENTE1 = new CLASES.CLIENTE();
            CLIENTE1.CEDULACLIENTE1 = TxtCedula.Text;
            CLIENTE1.GENERARLISTACEDULACLIENTE();
            CLIENTE1.APPATERNO1 = TxtApPaterno.Text;
            CLIENTE1.APMATERNO1 = TxtApMaterno.Text;
            CLIENTE1.NOMBRES1 = TxtNombres.Text;
            CLIENTE1.SEXO1 = CmbSexo.Text;
            CLIENTE1.NUMEROSEGURIDADSOCIAL1 = TxtNumSegSoc.Text;
            CLIENTE1.CATEGORIA1 = CmbCategoria.Text;
            CLIENTE1.GENERARCODIGODEPEDIDO();
            TxtCodigoPedido.Text = CLIENTE1.CODIGODEPEDIDO1;
            dataGridView1.Rows.Insert(0, CLIENTE1.APPATERNO1, CLIENTE1.APMATERNO1, CLIENTE1.NOMBRES1, CLIENTE1.SEXO1, CLIENTE1.NUMEROSEGURIDADSOCIAL1, CLIENTE1.CATEGORIA1, CLIENTE1.CODIGODEPEDIDO1, CLIENTE1.CEDULACLIENTE1);
        }
    }
}
