namespace EcomerceTech
{
    partial class FormProductos
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
            lblCaracteristicas = new Label();
            txtProducto = new TextBox();
            txtTipo = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            cmbTipo = new ComboBox();
            lstTiposProductos = new ListBox();
            btnVolver = new Button();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(457, 173);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Producto: ";
            // 
            // lblCaracteristicas
            // 
            lblCaracteristicas.AutoSize = true;
            lblCaracteristicas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaracteristicas.Location = new Point(457, 223);
            lblCaracteristicas.Name = "lblCaracteristicas";
            lblCaracteristicas.Size = new Size(44, 21);
            lblCaracteristicas.TabIndex = 1;
            lblCaracteristicas.Text = "Tipo";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(557, 171);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(177, 27);
            txtProducto.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.Enabled = false;
            txtTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(557, 221);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(177, 27);
            txtTipo.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(557, 319);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(177, 27);
            txtStock.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(557, 269);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(177, 27);
            txtPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(457, 321);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 21);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(457, 271);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(58, 21);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // cmbTipo
            // 
            cmbTipo.Cursor = Cursors.Hand;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(83, 84);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(269, 23);
            cmbTipo.TabIndex = 8;
            // 
            // lstTiposProductos
            // 
            lstTiposProductos.FormattingEnabled = true;
            lstTiposProductos.ItemHeight = 15;
            lstTiposProductos.Location = new Point(83, 139);
            lstTiposProductos.Name = "lstTiposProductos";
            lstTiposProductos.Size = new Size(269, 274);
            lstTiposProductos.TabIndex = 9;
            lstTiposProductos.SelectedIndexChanged += lstTiposProductos_SelectedIndexChanged;
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
            btnVolver.TabIndex = 10;
            btnVolver.Text = "<--";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(696, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(38, 38);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Crimson;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ButtonHighlight;
            btnBorrar.Location = new Point(740, 27);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(38, 38);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "-";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkSlateGray;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(652, 27);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(38, 38);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnVolver);
            Controls.Add(lstTiposProductos);
            Controls.Add(cmbTipo);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(txtTipo);
            Controls.Add(txtProducto);
            Controls.Add(lblCaracteristicas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            FormClosing += FormProductos_FormClosing;
            Load += FormProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCaracteristicas;
        private TextBox txtProducto;
        private TextBox txtTipo;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label lblStock;
        private Label lblPrecio;
        private ComboBox cmbTipo;
        private ListBox lstTiposProductos;
        private Button btnVolver;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}