namespace Avance
{
    partial class LoginEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioEstudiante = new System.Windows.Forms.TextBox();
            this.ContraseñaEstudiante = new System.Windows.Forms.TextBox();
            this.IngresarEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // UsuarioEstudiante
            // 
            this.UsuarioEstudiante.Location = new System.Drawing.Point(408, 160);
            this.UsuarioEstudiante.Name = "UsuarioEstudiante";
            this.UsuarioEstudiante.Size = new System.Drawing.Size(100, 20);
            this.UsuarioEstudiante.TabIndex = 3;
            // 
            // ContraseñaEstudiante
            // 
            this.ContraseñaEstudiante.Location = new System.Drawing.Point(408, 230);
            this.ContraseñaEstudiante.Name = "ContraseñaEstudiante";
            this.ContraseñaEstudiante.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaEstudiante.TabIndex = 4;
            this.ContraseñaEstudiante.UseSystemPasswordChar = true;
            // 
            // IngresarEstudiante
            // 
            this.IngresarEstudiante.Location = new System.Drawing.Point(376, 316);
            this.IngresarEstudiante.Name = "IngresarEstudiante";
            this.IngresarEstudiante.Size = new System.Drawing.Size(66, 24);
            this.IngresarEstudiante.TabIndex = 5;
            this.IngresarEstudiante.Text = "Ingresar";
            this.IngresarEstudiante.UseVisualStyleBackColor = true;
            this.IngresarEstudiante.Click += new System.EventHandler(this.IngresarEstudiante_Click);
            // 
            // LoginEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngresarEstudiante);
            this.Controls.Add(this.ContraseñaEstudiante);
            this.Controls.Add(this.UsuarioEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginEstudiante";
            this.Text = "LoginEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioEstudiante;
        private System.Windows.Forms.TextBox ContraseñaEstudiante;
        private System.Windows.Forms.Button IngresarEstudiante;
    }
}