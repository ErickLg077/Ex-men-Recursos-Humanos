
namespace FORMULRIOS
{
    partial class FRMEMPLEADOS
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
            this.LblTipoEmpleado = new System.Windows.Forms.GroupBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CboTipoContrato = new System.Windows.Forms.ComboBox();
            this.CboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.TxtNumSegSec = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblTipoContrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumSegSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGUSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULAEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTipoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoEmpleado
            // 
            this.LblTipoEmpleado.Controls.Add(this.TxtCedula);
            this.LblTipoEmpleado.Controls.Add(this.LblCedula);
            this.LblTipoEmpleado.Controls.Add(this.BtnGuardar);
            this.LblTipoEmpleado.Controls.Add(this.CboTipoContrato);
            this.LblTipoEmpleado.Controls.Add(this.CboTipoEmpleado);
            this.LblTipoEmpleado.Controls.Add(this.CboSexo);
            this.LblTipoEmpleado.Controls.Add(this.TxtNumSegSec);
            this.LblTipoEmpleado.Controls.Add(this.TxtApMaterno);
            this.LblTipoEmpleado.Controls.Add(this.TxtApPaterno);
            this.LblTipoEmpleado.Controls.Add(this.TxtNombres);
            this.LblTipoEmpleado.Controls.Add(this.LblTipoContrato);
            this.LblTipoEmpleado.Controls.Add(this.label1);
            this.LblTipoEmpleado.Controls.Add(this.NumSegSoc);
            this.LblTipoEmpleado.Controls.Add(this.LblSexo);
            this.LblTipoEmpleado.Controls.Add(this.LblNombres);
            this.LblTipoEmpleado.Controls.Add(this.LblApMaterno);
            this.LblTipoEmpleado.Controls.Add(this.LblApPaterno);
            this.LblTipoEmpleado.Location = new System.Drawing.Point(53, 67);
            this.LblTipoEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.LblTipoEmpleado.Name = "LblTipoEmpleado";
            this.LblTipoEmpleado.Padding = new System.Windows.Forms.Padding(5);
            this.LblTipoEmpleado.Size = new System.Drawing.Size(1416, 375);
            this.LblTipoEmpleado.TabIndex = 0;
            this.LblTipoEmpleado.TabStop = false;
            this.LblTipoEmpleado.Text = "Empleados";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(893, 267);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(259, 30);
            this.TxtCedula.TabIndex = 16;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(888, 222);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(75, 25);
            this.LblCedula.TabIndex = 15;
            this.LblCedula.Text = "Cédula";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(1198, 222);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(187, 78);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CboTipoContrato
            // 
            this.CboTipoContrato.FormattingEnabled = true;
            this.CboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CboTipoContrato.Location = new System.Drawing.Point(640, 267);
            this.CboTipoContrato.Margin = new System.Windows.Forms.Padding(5);
            this.CboTipoContrato.Name = "CboTipoContrato";
            this.CboTipoContrato.Size = new System.Drawing.Size(182, 33);
            this.CboTipoContrato.TabIndex = 13;
            this.CboTipoContrato.Text = "NUEVO";
            // 
            // CboTipoEmpleado
            // 
            this.CboTipoEmpleado.FormattingEnabled = true;
            this.CboTipoEmpleado.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.CboTipoEmpleado.Location = new System.Drawing.Point(347, 267);
            this.CboTipoEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.CboTipoEmpleado.Name = "CboTipoEmpleado";
            this.CboTipoEmpleado.Size = new System.Drawing.Size(251, 33);
            this.CboTipoEmpleado.TabIndex = 12;
            this.CboTipoEmpleado.Text = "VENDEDOR";
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CboSexo.Location = new System.Drawing.Point(1026, 121);
            this.CboSexo.Margin = new System.Windows.Forms.Padding(5);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(212, 33);
            this.CboSexo.TabIndex = 11;
            this.CboSexo.Text = "FEMENINO";
            // 
            // TxtNumSegSec
            // 
            this.TxtNumSegSec.Location = new System.Drawing.Point(50, 267);
            this.TxtNumSegSec.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNumSegSec.Name = "TxtNumSegSec";
            this.TxtNumSegSec.Size = new System.Drawing.Size(259, 30);
            this.TxtNumSegSec.TabIndex = 10;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(347, 124);
            this.TxtApMaterno.Margin = new System.Windows.Forms.Padding(5);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(245, 30);
            this.TxtApMaterno.TabIndex = 9;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(52, 124);
            this.TxtApPaterno.Margin = new System.Windows.Forms.Padding(5);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(257, 30);
            this.TxtApPaterno.TabIndex = 8;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(640, 124);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(339, 30);
            this.TxtNombres.TabIndex = 7;
            // 
            // LblTipoContrato
            // 
            this.LblTipoContrato.AutoSize = true;
            this.LblTipoContrato.Location = new System.Drawing.Point(635, 222);
            this.LblTipoContrato.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTipoContrato.Name = "LblTipoContrato";
            this.LblTipoContrato.Size = new System.Drawing.Size(158, 25);
            this.LblTipoContrato.TabIndex = 6;
            this.LblTipoContrato.Text = "Tipo de Contrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Empleado";
            // 
            // NumSegSoc
            // 
            this.NumSegSoc.AutoSize = true;
            this.NumSegSoc.Location = new System.Drawing.Point(47, 222);
            this.NumSegSoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumSegSoc.Name = "NumSegSoc";
            this.NumSegSoc.Size = new System.Drawing.Size(262, 25);
            this.NumSegSoc.TabIndex = 4;
            this.NumSegSoc.Text = "Numero de Seguridad Social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(1021, 76);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(58, 25);
            this.LblSexo.TabIndex = 3;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(635, 76);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(91, 25);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(354, 76);
            this.LblApMaterno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(159, 25);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido Materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(47, 76);
            this.LblApPaterno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(155, 25);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.AllowUserToOrderColumns = true;
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGUSOC,
            this.TIPOEMPLEADO,
            this.TIPOCONTRATO,
            this.CEDULAEMPLEADO,
            this.SUELDO});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(50, 461);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.RowHeadersWidth = 51;
            this.DGVEMPLEADOS.RowTemplate.Height = 24;
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(1419, 231);
            this.DGVEMPLEADOS.TabIndex = 1;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 245;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 250;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 150;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 125;
            // 
            // NUMSEGUSOC
            // 
            this.NUMSEGUSOC.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGUSOC.MinimumWidth = 6;
            this.NUMSEGUSOC.Name = "NUMSEGUSOC";
            this.NUMSEGUSOC.Width = 240;
            // 
            // TIPOEMPLEADO
            // 
            this.TIPOEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPOEMPLEADO.MinimumWidth = 6;
            this.TIPOEMPLEADO.Name = "TIPOEMPLEADO";
            this.TIPOEMPLEADO.Width = 125;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.MinimumWidth = 6;
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 125;
            // 
            // CEDULAEMPLEADO
            // 
            this.CEDULAEMPLEADO.HeaderText = "CÉDULA";
            this.CEDULAEMPLEADO.MinimumWidth = 6;
            this.CEDULAEMPLEADO.Name = "CEDULAEMPLEADO";
            this.CEDULAEMPLEADO.Width = 150;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 6;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 125;
            // 
            // FRMEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.DGVEMPLEADOS);
            this.Controls.Add(this.LblTipoEmpleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMEMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEMPLEADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMEMPLEADOS_Load);
            this.LblTipoEmpleado.ResumeLayout(false);
            this.LblTipoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LblTipoEmpleado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CboTipoContrato;
        private System.Windows.Forms.ComboBox CboTipoEmpleado;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.TextBox TxtNumSegSec;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblTipoContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumSegSoc;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGUSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULAEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
    }
}