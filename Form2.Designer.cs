namespace Calculadora
{
    partial class Menu
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
            this.bntSen = new System.Windows.Forms.Button();
            this.bntTan = new System.Windows.Forms.Button();
            this.bntCOS = new System.Windows.Forms.Button();
            this.Titulodefunciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntSen
            // 
            this.bntSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSen.Location = new System.Drawing.Point(156, 68);
            this.bntSen.Name = "bntSen";
            this.bntSen.Size = new System.Drawing.Size(99, 45);
            this.bntSen.TabIndex = 0;
            this.bntSen.Tag = "S";
            this.bntSen.Text = "SEN";
            this.bntSen.UseVisualStyleBackColor = true;
            this.bntSen.Click += new System.EventHandler(this.botonpresionado);
            // 
            // bntTan
            // 
            this.bntTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTan.Location = new System.Drawing.Point(156, 170);
            this.bntTan.Name = "bntTan";
            this.bntTan.Size = new System.Drawing.Size(99, 45);
            this.bntTan.TabIndex = 3;
            this.bntTan.Tag = "T";
            this.bntTan.Text = "TAN";
            this.bntTan.UseVisualStyleBackColor = true;
            this.bntTan.Click += new System.EventHandler(this.botonpresionado);
            // 
            // bntCOS
            // 
            this.bntCOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCOS.Location = new System.Drawing.Point(156, 119);
            this.bntCOS.Name = "bntCOS";
            this.bntCOS.Size = new System.Drawing.Size(99, 45);
            this.bntCOS.TabIndex = 4;
            this.bntCOS.Tag = "C";
            this.bntCOS.Text = "COS";
            this.bntCOS.UseVisualStyleBackColor = true;
            this.bntCOS.Click += new System.EventHandler(this.botonpresionado);
            // 
            // Titulodefunciones
            // 
            this.Titulodefunciones.AutoSize = true;
            this.Titulodefunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulodefunciones.Location = new System.Drawing.Point(45, 9);
            this.Titulodefunciones.Name = "Titulodefunciones";
            this.Titulodefunciones.Size = new System.Drawing.Size(325, 32);
            this.Titulodefunciones.TabIndex = 5;
            this.Titulodefunciones.Text = "Funciones Trigometricas";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 241);
            this.Controls.Add(this.Titulodefunciones);
            this.Controls.Add(this.bntCOS);
            this.Controls.Add(this.bntTan);
            this.Controls.Add(this.bntSen);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSen;
        private System.Windows.Forms.Button bntTan;
        private System.Windows.Forms.Button bntCOS;
        private System.Windows.Forms.Label Titulodefunciones;
    }
}