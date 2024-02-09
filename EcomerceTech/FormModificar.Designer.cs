namespace EcomerceTech
{
    partial class FormModificar
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
            cmbTipo = new ComboBox();
            btnCancelar = new Button();
            btnRegistar = new Button();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(100, 271);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(215, 28);
            cmbTipo.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(248, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            btnRegistar.Cursor = Cursors.Hand;
            btnRegistar.Location = new Point(83, 342);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(86, 41);
            btnRegistar.TabIndex = 11;
            btnRegistar.Text = "Modificar";
            btnRegistar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(100, 210);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(215, 27);
            txtStock.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(100, 149);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(215, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(100, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(215, 27);
            txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 7;
            label1.Text = "Modificar";
            // 
            // FormModificar
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
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Button btnCancelar;
        private Button btnRegistar;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label1;
    }
}