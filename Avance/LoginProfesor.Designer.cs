namespace Avance
{
    partial class LoginProfesor
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
            this.IngresarProfesor = new System.Windows.Forms.Button();
            this.ContraseñaProfesor = new System.Windows.Forms.TextBox();
            this.UsuarioProfesor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngresarProfesor
            // 
            this.IngresarProfesor.Location = new System.Drawing.Point(376, 316);
            this.IngresarProfesor.Name = "IngresarProfesor";
            this.IngresarProfesor.Size = new System.Drawing.Size(66, 24);
            this.IngresarProfesor.TabIndex = 11;
            this.IngresarProfesor.Text = "Ingresar";
            this.IngresarProfesor.UseVisualStyleBackColor = true;
            this.IngresarProfesor.Click += new System.EventHandler(this.IngresarProfesor_Click);

            // 
            // ContraseñaProfesor
            // 
            this.ContraseñaProfesor.Location = new System.Drawing.Point(408, 230);
            this.ContraseñaProfesor.Name = "ContraseñaProfesor";
            this.ContraseñaProfesor.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaProfesor.TabIndex = 10;
            this.ContraseñaProfesor.UseSystemPasswordChar = true;
            // 
            // UsuarioProfesor
            // 
            this.UsuarioProfesor.Location = new System.Drawing.Point(408, 160);
            this.UsuarioProfesor.Name = "UsuarioProfesor";
            this.UsuarioProfesor.Size = new System.Drawing.Size(100, 20);
            this.UsuarioProfesor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profesor";
            // 
            // LoginProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngresarProfesor);
            this.Controls.Add(this.ContraseñaProfesor);
            this.Controls.Add(this.UsuarioProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginProfesor";
            this.Text = "LoginProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IngresarProfesor;
        private System.Windows.Forms.TextBox ContraseñaProfesor;
        private System.Windows.Forms.TextBox UsuarioProfesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}