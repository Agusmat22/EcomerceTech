namespace EcomerceTech
{
    partial class FormRegistrar
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnRegistar = new Button();
            btnCancelar = new Button();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(98, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(215, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(98, 149);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(215, 27);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(98, 210);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(215, 27);
            txtStock.TabIndex = 3;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // btnRegistar
            // 
            btnRegistar.Cursor = Cursors.Hand;
            btnRegistar.Location = new Point(81, 342);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(86, 41);
            btnRegistar.TabIndex = 4;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(246, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(98, 271);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(215, 28);
            cmbTipo.TabIndex = 6;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 395);
            Controls.Add(cmbTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            Load += FormRegistrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnRegistar;
        private Button btnCancelar;
        private ComboBox cmbTipo;
    }
}