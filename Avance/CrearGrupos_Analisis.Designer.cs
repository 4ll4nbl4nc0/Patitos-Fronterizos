namespace Avance
{
    partial class CrearGrupos_Analisis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IrAListaGrupos = new System.Windows.Forms.Button();
            this.textBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.listBoxSeleccionados = new System.Windows.Forms.ListBox();
            this.buttonCrearGrupo = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 612);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 100);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Creación de Grupos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Estudiantes";
            // 
            // IrAListaGrupos
            // 
            this.IrAListaGrupos.Location = new System.Drawing.Point(599, 513);
            this.IrAListaGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.IrAListaGrupos.Name = "IrAListaGrupos";
            this.IrAListaGrupos.Size = new System.Drawing.Size(100, 28);
            this.IrAListaGrupos.TabIndex = 14;
            this.IrAListaGrupos.Text = "Cancelar";
            this.IrAListaGrupos.UseVisualStyleBackColor = true;
            this.IrAListaGrupos.Click += new System.EventHandler(this.IrAListaGrupos_Click);
            // 
            // textBoxNombreGrupo
            // 
            this.textBoxNombreGrupo.Location = new System.Drawing.Point(499, 155);
            this.textBoxNombreGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            this.textBoxNombreGrupo.Size = new System.Drawing.Size(173, 22);
            this.textBoxNombreGrupo.TabIndex = 13;
            // 
            // listBoxSeleccionados
            // 
            this.listBoxSeleccionados.FormattingEnabled = true;
            this.listBoxSeleccionados.ItemHeight = 16;
            this.listBoxSeleccionados.Location = new System.Drawing.Point(719, 251);
            this.listBoxSeleccionados.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSeleccionados.Name = "listBoxSeleccionados";
            this.listBoxSeleccionados.Size = new System.Drawing.Size(229, 164);
            this.listBoxSeleccionados.TabIndex = 12;
            // 
            // buttonCrearGrupo
            // 
            this.buttonCrearGrupo.Location = new System.Drawing.Point(478, 513);
            this.buttonCrearGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearGrupo.Name = "buttonCrearGrupo";
            this.buttonCrearGrupo.Size = new System.Drawing.Size(113, 28);
            this.buttonCrearGrupo.TabIndex = 11;
            this.buttonCrearGrupo.Text = "Crear";
            this.buttonCrearGrupo.UseVisualStyleBackColor = true;
            this.buttonCrearGrupo.Click += new System.EventHandler(this.buttonCrearGrupo_Click);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(299, 213);
            this.dataGridViewEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.ReadOnly = true;
            this.dataGridViewEstudiantes.RowHeadersWidth = 51;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(387, 267);
            this.dataGridViewEstudiantes.TabIndex = 10;
            this.dataGridViewEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstudiantes_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre de Grupo";
            // 
            // CrearGrupos_Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IrAListaGrupos);
            this.Controls.Add(this.textBoxNombreGrupo);
            this.Controls.Add(this.listBoxSeleccionados);
            this.Controls.Add(this.buttonCrearGrupo);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CrearGrupos_Analisis";
            this.Text = "CrearGrupos_Analisis";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IrAListaGrupos;
        private System.Windows.Forms.TextBox textBoxNombreGrupo;
        private System.Windows.Forms.ListBox listBoxSeleccionados;
        private System.Windows.Forms.Button buttonCrearGrupo;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.Label label3;
    }
}