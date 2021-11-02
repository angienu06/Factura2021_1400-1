
namespace Factura2021_1400.Vistas
{
    partial class UsuariosView
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
            this.EsAdministradorCheckBox = new System.Windows.Forms.CheckBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLAVE:";
            // 
            // EsAdministradorCheckBox
            // 
            this.EsAdministradorCheckBox.AutoSize = true;
            this.EsAdministradorCheckBox.Enabled = false;
            this.EsAdministradorCheckBox.Location = new System.Drawing.Point(160, 193);
            this.EsAdministradorCheckBox.Name = "EsAdministradorCheckBox";
            this.EsAdministradorCheckBox.Size = new System.Drawing.Size(190, 24);
            this.EsAdministradorCheckBox.TabIndex = 4;
            this.EsAdministradorCheckBox.Text = "ES ADMINISTRADOR";
            this.EsAdministradorCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(160, 19);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.ReadOnly = true;
            this.IdtextBox.Size = new System.Drawing.Size(144, 26);
            this.IdtextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(160, 55);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(487, 26);
            this.NombreTextBox.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(160, 100);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(487, 26);
            this.EmailTextBox.TabIndex = 7;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Enabled = false;
            this.ClaveTextBox.Location = new System.Drawing.Point(160, 146);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(487, 26);
            this.ClaveTextBox.TabIndex = 8;
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(0, 295);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.Size = new System.Drawing.Size(880, 135);
            this.UsuariosDataGridView.TabIndex = 9;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(158, 238);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 35);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(257, 238);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(93, 35);
            this.ModificarButton.TabIndex = 11;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(356, 238);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 35);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(455, 238);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 35);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(554, 238);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 35);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 429);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.EsAdministradorCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsuariosView";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox EsAdministradorCheckBox;
        public System.Windows.Forms.TextBox IdtextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox ClaveTextBox;
        public System.Windows.Forms.DataGridView UsuariosDataGridView;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}