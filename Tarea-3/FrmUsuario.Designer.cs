namespace Tarea_3
{
    partial class FrmUsuario
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
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(45, 37);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(442, 150);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(54, 238);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(182, 23);
            this.MostrarButton.TabIndex = 1;
            this.MostrarButton.Text = "Mostrar Usuarios";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.Location = new System.Drawing.Point(695, 313);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(75, 23);
            this.buttonsalir.TabIndex = 2;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Button buttonsalir;
    }
}