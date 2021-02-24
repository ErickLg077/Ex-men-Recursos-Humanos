
namespace FORMULRIOS
{
    partial class FRMCLIENTES
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
            this.GPBCliente = new System.Windows.Forms.GroupBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULACLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCliente
            // 
            this.GPBCliente.Controls.Add(this.TxtCedula);
            this.GPBCliente.Controls.Add(this.LblCedula);
            this.GPBCliente.Controls.Add(this.BtnGuardar);
            this.GPBCliente.Controls.Add(this.button1);
            this.GPBCliente.Controls.Add(this.CmbSexo);
            this.GPBCliente.Controls.Add(this.CmbCategoria);
            this.GPBCliente.Controls.Add(this.TxtNumSegSoc);
            this.GPBCliente.Controls.Add(this.TxtNombres);
            this.GPBCliente.Controls.Add(this.TxtCodigoPedido);
            this.GPBCliente.Controls.Add(this.TxtApMaterno);
            this.GPBCliente.Controls.Add(this.TxtApPaterno);
            this.GPBCliente.Controls.Add(this.LblCodigoPedido);
            this.GPBCliente.Controls.Add(this.LblCategoria);
            this.GPBCliente.Controls.Add(this.LblNumSegSoc);
            this.GPBCliente.Controls.Add(this.LblSexo);
            this.GPBCliente.Controls.Add(this.LblNombres);
            this.GPBCliente.Controls.Add(this.LblApMaterno);
            this.GPBCliente.Controls.Add(this.LblApPaterno);
            this.GPBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBCliente.Location = new System.Drawing.Point(39, 47);
            this.GPBCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GPBCliente.Name = "GPBCliente";
            this.GPBCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GPBCliente.Size = new System.Drawing.Size(1460, 416);
            this.GPBCliente.TabIndex = 0;
            this.GPBCliente.TabStop = false;
            this.GPBCliente.Text = "Cliente";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(976, 264);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(252, 34);
            this.TxtCedula.TabIndex = 16;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(971, 214);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(90, 29);
            this.LblCedula.TabIndex = 15;
            this.LblCedula.Text = "Cédula";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(1256, 240);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(182, 58);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2030, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(1226, 121);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(201, 37);
            this.CmbSexo.TabIndex = 13;
            this.CmbSexo.Text = "FEMENINO";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CmbCategoria.Location = new System.Drawing.Point(394, 261);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(202, 37);
            this.CmbCategoria.TabIndex = 12;
            this.CmbCategoria.Text = "NUEVO";
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSoc.Location = new System.Drawing.Point(27, 261);
            this.TxtNumSegSoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(321, 34);
            this.TxtNumSegSoc.TabIndex = 11;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(784, 121);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(384, 34);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPedido.Location = new System.Drawing.Point(653, 264);
            this.TxtCodigoPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(252, 34);
            this.TxtCodigoPedido.TabIndex = 9;
            this.TxtCodigoPedido.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMaterno.Location = new System.Drawing.Point(394, 121);
            this.TxtApMaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(320, 34);
            this.TxtApMaterno.TabIndex = 8;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaterno.Location = new System.Drawing.Point(27, 121);
            this.TxtApPaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(321, 34);
            this.TxtApPaterno.TabIndex = 7;
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoPedido.Location = new System.Drawing.Point(648, 214);
            this.LblCodigoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(214, 29);
            this.LblCodigoPedido.TabIndex = 6;
            this.LblCodigoPedido.Text = "Código del pedido";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(389, 214);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(118, 29);
            this.LblCategoria.TabIndex = 5;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSoc.Location = new System.Drawing.Point(25, 214);
            this.LblNumSegSoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(323, 29);
            this.LblNumSegSoc.TabIndex = 4;
            this.LblNumSegSoc.Text = "Numero del seguridad social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(1221, 78);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(68, 29);
            this.LblSexo.TabIndex = 3;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(779, 78);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(113, 29);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApMaterno.Location = new System.Drawing.Point(389, 78);
            this.LblApMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(196, 29);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApPaterno.Location = new System.Drawing.Point(22, 78);
            this.LblApPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(190, 29);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido paterno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.CATEGORIA,
            this.CODIGOPEDIDO,
            this.CEDULACLIENTE});
            this.dataGridView1.Location = new System.Drawing.Point(39, 473);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 240;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 245;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 220;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 125;
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.MinimumWidth = 6;
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 250;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORÍA";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 165;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CÓDIGO DEL PEDIDO";
            this.CODIGOPEDIDO.MinimumWidth = 6;
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 160;
            // 
            // CEDULACLIENTE
            // 
            this.CEDULACLIENTE.HeaderText = "CÉDULA";
            this.CEDULACLIENTE.MinimumWidth = 6;
            this.CEDULACLIENTE.Name = "CEDULACLIENTE";
            this.CEDULACLIENTE.Width = 125;
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GPBCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCLIENTES";
            this.Text = "FRMCLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GPBCliente.ResumeLayout(false);
            this.GPBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCliente;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULACLIENTE;
    }
}