namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.GridAvion = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAvion
            // 
            this.GridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAvion.Location = new System.Drawing.Point(31, 233);
            this.GridAvion.Name = "GridAvion";
            this.GridAvion.RowHeadersWidth = 51;
            this.GridAvion.RowTemplate.Height = 24;
            this.GridAvion.Size = new System.Drawing.Size(364, 189);
            this.GridAvion.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(523, 22);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(225, 64);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capacidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Denominacion:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(186, 22);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(209, 22);
            this.txtCapacidad.TabIndex = 4;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(186, 70);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(209, 22);
            this.txtDenominacion.TabIndex = 5;
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.GridAvion);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAvion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
    }
}