namespace Avance
{
    partial class InterfazInicialEstudiante
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
            this.listViewCursos = new System.Windows.Forms.ListView();
            this.TextoBienvenidaEstudiante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCursos
            // 
            this.listViewCursos.FullRowSelect = true;
            this.listViewCursos.HideSelection = false;
            this.listViewCursos.Location = new System.Drawing.Point(329, 259);
            this.listViewCursos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(373, 259);
            this.listViewCursos.TabIndex = 3;
            this.listViewCursos.UseCompatibleStateImageBehavior = false;
            this.listViewCursos.View = System.Windows.Forms.View.Details;
            this.listViewCursos.ItemActivate += new System.EventHandler(this.ListViewCursos_ItemActivate);
            // 
            // TextoBienvenidaEstudiante
            // 
            this.TextoBienvenidaEstudiante.AutoSize = true;
            this.TextoBienvenidaEstudiante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBienvenidaEstudiante.Location = new System.Drawing.Point(362, 95);
            this.TextoBienvenidaEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoBienvenidaEstudiante.Name = "TextoBienvenidaEstudiante";
            this.TextoBienvenidaEstudiante.Size = new System.Drawing.Size(280, 37);
            this.TextoBienvenidaEstudiante.TabIndex = 2;
            this.TextoBienvenidaEstudiante.Text = "Bienvenido Estudiante";
            // 
            // InterfazInicialEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.listViewCursos);
            this.Controls.Add(this.TextoBienvenidaEstudiante);
            this.Name = "InterfazInicialEstudiante";
            this.Text = "InterfazInicialEstudiante";
            this.Load += new System.EventHandler(this.InterfazInicialEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCursos;
        private System.Windows.Forms.Label TextoBienvenidaEstudiante;
    }
}