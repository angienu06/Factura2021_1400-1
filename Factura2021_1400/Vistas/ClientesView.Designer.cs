
namespace Factura2021_1400.Vistas
{
    partial class ClientesView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.ImagenButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdentidadMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(137, 31);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 22);
            this.IdTextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(137, 136);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(223, 22);
            this.NombreTextBox.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(137, 192);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(223, 22);
            this.EmailTextBox.TabIndex = 8;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Enabled = false;
            this.DireccionTextBox.Location = new System.Drawing.Point(137, 247);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(223, 22);
            this.DireccionTextBox.TabIndex = 9;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.ImagenPictureBox.Location = new System.Drawing.Point(430, 31);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(300, 238);
            this.ImagenPictureBox.TabIndex = 10;
            this.ImagenPictureBox.TabStop = false;
            // 
            // ImagenButton
            // 
            this.ImagenButton.Enabled = false;
            this.ImagenButton.Location = new System.Drawing.Point(655, 273);
            this.ImagenButton.Name = "ImagenButton";
            this.ImagenButton.Size = new System.Drawing.Size(76, 25);
            this.ImagenButton.TabIndex = 11;
            this.ImagenButton.Text = "Imagen ...";
            this.ImagenButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(534, 342);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 35);
            this.CancelarButton.TabIndex = 19;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(435, 342);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 35);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(336, 342);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 35);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(237, 342);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(93, 35);
            this.ModificarButton.TabIndex = 16;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(138, 342);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 35);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 399);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(760, 123);
            this.ClientesDataGridView.TabIndex = 20;
            // 
            // IdentidadMaskedTextBox
            // 
            this.IdentidadMaskedTextBox.Location = new System.Drawing.Point(138, 77);
            this.IdentidadMaskedTextBox.Name = "IdentidadMaskedTextBox";
            this.IdentidadMaskedTextBox.Size = new System.Drawing.Size(222, 22);
            this.IdentidadMaskedTextBox.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 522);
            this.Controls.Add(this.IdentidadMaskedTextBox);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ImagenButton);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientesView";
            this.Text = "ClientesView";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox IdentidadMaskedTextBox;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox DireccionTextBox;
        public System.Windows.Forms.PictureBox ImagenPictureBox;
        public System.Windows.Forms.Button ImagenButton;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.DataGridView ClientesDataGridView;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}