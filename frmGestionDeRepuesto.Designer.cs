namespace pryRoldanGestionDeRepuestos
{
    partial class frmGestionDeRepuesto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbIngreso = new GroupBox();
            cmdAgregarRepuesto = new Button();
            lstOrigen = new ComboBox();
            lblOrigen = new Label();
            mtbPrecio = new MaskedTextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            mtbRepuestos = new MaskedTextBox();
            lstMarca = new ComboBox();
            lblNumeroRepuesto = new Label();
            lblMarca = new Label();
            groupBox1 = new GroupBox();
            cmdConsultar = new Button();
            ltbResultado = new ListBox();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            lblOrigen2 = new Label();
            lstMarca2 = new ComboBox();
            lblMarca2 = new Label();
            grbIngreso.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbIngreso
            // 
            grbIngreso.Controls.Add(cmdAgregarRepuesto);
            grbIngreso.Controls.Add(lstOrigen);
            grbIngreso.Controls.Add(lblOrigen);
            grbIngreso.Controls.Add(mtbPrecio);
            grbIngreso.Controls.Add(lblPrecio);
            grbIngreso.Controls.Add(txtDescripcion);
            grbIngreso.Controls.Add(lblDescripcion);
            grbIngreso.Controls.Add(mtbRepuestos);
            grbIngreso.Controls.Add(lstMarca);
            grbIngreso.Controls.Add(lblNumeroRepuesto);
            grbIngreso.Controls.Add(lblMarca);
            grbIngreso.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbIngreso.Location = new Point(28, 22);
            grbIngreso.Name = "grbIngreso";
            grbIngreso.Size = new Size(737, 256);
            grbIngreso.TabIndex = 0;
            grbIngreso.TabStop = false;
            grbIngreso.Text = "Ingreso De Repuestos ";
          
            // 
            // cmdAgregarRepuesto
            // 
            cmdAgregarRepuesto.Location = new Point(391, 149);
            cmdAgregarRepuesto.Name = "cmdAgregarRepuesto";
            cmdAgregarRepuesto.Size = new Size(195, 29);
            cmdAgregarRepuesto.TabIndex = 5;
            cmdAgregarRepuesto.Text = "Agregar Repuesto";
            cmdAgregarRepuesto.UseVisualStyleBackColor = true;
            cmdAgregarRepuesto.Click += cmdAgregarRepuesto_Click;
            // 
            // lstOrigen
            // 
            lstOrigen.FormattingEnabled = true;
            lstOrigen.Items.AddRange(new object[] { "Nacional ", "Importado " });
            lstOrigen.Location = new Point(435, 64);
            lstOrigen.Name = "lstOrigen";
            lstOrigen.Size = new Size(151, 28);
            lstOrigen.TabIndex = 4;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(357, 66);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(72, 20);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen ";
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(146, 197);
            mtbPrecio.Mask = "99999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(151, 28);
            mtbPrecio.TabIndex = 3;
            mtbPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(65, 197);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 20);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 139);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(151, 28);
            txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 139);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(108, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // mtbRepuestos
            // 
            mtbRepuestos.Location = new Point(146, 87);
            mtbRepuestos.Mask = "999999";
            mtbRepuestos.Name = "mtbRepuestos";
            mtbRepuestos.Size = new Size(151, 28);
            mtbRepuestos.TabIndex = 1;
            // 
            // lstMarca
            // 
            lstMarca.FormattingEnabled = true;
            lstMarca.Items.AddRange(new object[] { "Peugeot (P)", "Fiat (F)", "Renault (R)" });
            lstMarca.Location = new Point(146, 43);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(151, 28);
            lstMarca.TabIndex = 0;
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Location = new Point(17, 90);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(111, 20);
            lblNumeroRepuesto.TabIndex = 1;
            lblNumeroRepuesto.Text = "N°Repuesto";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(69, 46);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(59, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdConsultar);
            groupBox1.Controls.Add(ltbResultado);
            groupBox1.Controls.Add(optImportado);
            groupBox1.Controls.Add(optNacional);
            groupBox1.Controls.Add(lblOrigen2);
            groupBox1.Controls.Add(lstMarca2);
            groupBox1.Controls.Add(lblMarca2);
            groupBox1.Location = new Point(28, 310);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(737, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta De Repuesto";
            // 
            // cmdConsultar
            // 
            cmdConsultar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdConsultar.Location = new Point(69, 139);
            cmdConsultar.Name = "cmdConsultar";
            cmdConsultar.Size = new Size(135, 29);
            cmdConsultar.TabIndex = 2;
            cmdConsultar.Text = "Consultar";
            cmdConsultar.UseVisualStyleBackColor = true;
            cmdConsultar.Click += cmdConsultar_Click;
            // 
            // ltbResultado
            // 
            ltbResultado.FormattingEnabled = true;
            ltbResultado.Location = new Point(357, 43);
            ltbResultado.Name = "ltbResultado";
            ltbResultado.Size = new Size(359, 124);
            ltbResultado.TabIndex = 3;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optImportado.Location = new Point(210, 98);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(127, 24);
            optImportado.TabIndex = 4;
            optImportado.TabStop = true;
            optImportado.Text = "Importado ";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optNacional.Location = new Point(95, 98);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(109, 24);
            optNacional.TabIndex = 1;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional ";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen2.Location = new Point(17, 98);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(72, 20);
            lblOrigen2.TabIndex = 2;
            lblOrigen2.Text = "Origen ";
            // 
            // lstMarca2
            // 
            lstMarca2.FormattingEnabled = true;
            lstMarca2.Items.AddRange(new object[] { "P", "F", "R" });
            lstMarca2.Location = new Point(82, 43);
            lstMarca2.Name = "lstMarca2";
            lstMarca2.Size = new Size(151, 28);
            lstMarca2.TabIndex = 0;
            // 
            // lblMarca2
            // 
            lblMarca2.AutoSize = true;
            lblMarca2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca2.Location = new Point(17, 45);
            lblMarca2.Name = "lblMarca2";
            lblMarca2.Size = new Size(59, 20);
            lblMarca2.TabIndex = 0;
            lblMarca2.Text = "Marca";
            // 
            // frmGestionDeRepuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(groupBox1);
            Controls.Add(grbIngreso);
            Name = "frmGestionDeRepuesto";
            Text = "Gestion De Repuestos ";
            Load += frmGestionDeRepuesto_Load;
            grbIngreso.ResumeLayout(false);
            grbIngreso.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbIngreso;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private MaskedTextBox mtbRepuestos;
        private ComboBox lstMarca;
        private Label lblNumeroRepuesto;
        private Label lblMarca;
        private MaskedTextBox mtbPrecio;
        private Label lblPrecio;
        private ComboBox lstOrigen;
        private Label lblOrigen;
        private Button cmdAgregarRepuesto;
        private GroupBox groupBox1;
        private Label lblOrigen2;
        private ComboBox lstMarca2;
        private Label lblMarca2;
        private Button cmdConsultar;
        private ListBox ltbResultado;
        private RadioButton optImportado;
        private RadioButton optNacional;
    }
}
