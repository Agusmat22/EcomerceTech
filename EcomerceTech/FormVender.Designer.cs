namespace EcomerceTech
{
    partial class FormVender
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
            label1 = new Label();
            cmbTipo = new ComboBox();
            label2 = new Label();
            lstbProductos = new ListBox();
            label3 = new Label();
            nudCantidad = new NumericUpDown();
            label4 = new Label();
            rtbTicket = new RichTextBox();
            label5 = new Label();
            btnCobrar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Facturar";
            // 
            // cmbTipo
            // 
            cmbTipo.Cursor = Cursors.Hand;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(35, 100);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(285, 29);
            cmbTipo.TabIndex = 9;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 67);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 10;
            label2.Text = "Tipo";
            // 
            // lstbProductos
            // 
            lstbProductos.FormattingEnabled = true;
            lstbProductos.ItemHeight = 15;
            lstbProductos.Location = new Point(35, 182);
            lstbProductos.Name = "lstbProductos";
            lstbProductos.Size = new Size(285, 169);
            lstbProductos.TabIndex = 11;
            lstbProductos.SelectedIndexChanged += lstbProductos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 12;
            label3.Text = "Producto";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(35, 407);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(285, 23);
            nudCantidad.TabIndex = 13;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(138, 373);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 14;
            label4.Text = "Cantidad";
            // 
            // rtbTicket
            // 
            rtbTicket.Location = new Point(557, 100);
            rtbTicket.Name = "rtbTicket";
            rtbTicket.Size = new Size(306, 261);
            rtbTicket.TabIndex = 15;
            rtbTicket.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(680, 67);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 16;
            label5.Text = "Tipo";
            // 
            // btnCobrar
            // 
            btnCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.Location = new Point(752, 399);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(111, 41);
            btnCobrar.TabIndex = 17;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(40, 31);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "<--";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormVender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 452);
            Controls.Add(btnVolver);
            Controls.Add(btnCobrar);
            Controls.Add(label5);
            Controls.Add(rtbTicket);
            Controls.Add(label4);
            Controls.Add(nudCantidad);
            Controls.Add(label3);
            Controls.Add(lstbProductos);
            Controls.Add(label2);
            Controls.Add(cmbTipo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVender";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVender";
            FormClosing += FormVender_FormClosing;
            Load += FormVender_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTipo;
        private Label label2;
        private ListBox lstbProductos;
        private Label label3;
        private NumericUpDown nudCantidad;
        private Label label4;
        private RichTextBox rtbTicket;
        private Label label5;
        private Button btnCobrar;
        private Button btnVolver;
    }
}