namespace EcomerceTech
{
    partial class Menu
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
            btnProductos = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnVentas = new Button();
            btnVender = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.Location = new Point(12, 12);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(238, 49);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(12, 372);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(238, 66);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(457, 76);
            label1.Name = "label1";
            label1.Size = new Size(161, 39);
            label1.TabIndex = 3;
            label1.Text = "Ecommerce";
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.Location = new Point(12, 76);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(238, 49);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.Green;
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.Location = new Point(742, 15);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(46, 46);
            btnVender.TabIndex = 5;
            btnVender.Text = "$";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVender);
            Controls.Add(btnVentas);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnProductos);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btnSalir;
        private Label label1;
        private Button btnVentas;
        private Button btnVender;
    }
}
