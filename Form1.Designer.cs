namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.TxtResultados = new System.Windows.Forms.TextBox();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.BtnSigno = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnNueve = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnOcho = new System.Windows.Forms.Button();
            this.BtnSiete = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnMultiplicacion = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnRaizCuadrada = new System.Windows.Forms.Button();
            this.BtnAlCuadrado = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnBorrarTodo = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.Btnsubmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultados
            // 
            this.TxtResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultados.Location = new System.Drawing.Point(20, 26);
            this.TxtResultados.MaxLength = 10;
            this.TxtResultados.Multiline = true;
            this.TxtResultados.Name = "TxtResultados";
            this.TxtResultados.ReadOnly = true;
            this.TxtResultados.Size = new System.Drawing.Size(298, 63);
            this.TxtResultados.TabIndex = 0;
            this.TxtResultados.Text = "0";
            this.TxtResultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnUno
            // 
            this.BtnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUno.Location = new System.Drawing.Point(20, 330);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(65, 45);
            this.BtnUno.TabIndex = 1;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnDos
            // 
            this.BtnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDos.Location = new System.Drawing.Point(91, 330);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(65, 45);
            this.BtnDos.TabIndex = 2;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = true;
            this.BtnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnTres
            // 
            this.BtnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTres.Location = new System.Drawing.Point(162, 330);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(65, 45);
            this.BtnTres.TabIndex = 3;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnCero
            // 
            this.BtnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCero.Location = new System.Drawing.Point(91, 381);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(65, 45);
            this.BtnCero.TabIndex = 4;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = true;
            this.BtnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnSigno
            // 
            this.BtnSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSigno.Location = new System.Drawing.Point(20, 381);
            this.BtnSigno.Name = "BtnSigno";
            this.BtnSigno.Size = new System.Drawing.Size(65, 45);
            this.BtnSigno.TabIndex = 5;
            this.BtnSigno.Text = "+/-";
            this.BtnSigno.UseVisualStyleBackColor = true;
            this.BtnSigno.Click += new System.EventHandler(this.BtnSigno_Click);
            // 
            // BtnPunto
            // 
            this.BtnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.Location = new System.Drawing.Point(162, 381);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(65, 45);
            this.BtnPunto.TabIndex = 6;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // BtnNueve
            // 
            this.BtnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNueve.Location = new System.Drawing.Point(162, 228);
            this.BtnNueve.Name = "BtnNueve";
            this.BtnNueve.Size = new System.Drawing.Size(65, 45);
            this.BtnNueve.TabIndex = 7;
            this.BtnNueve.Text = "9";
            this.BtnNueve.UseVisualStyleBackColor = true;
            this.BtnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnSeis
            // 
            this.BtnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeis.Location = new System.Drawing.Point(162, 279);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(65, 45);
            this.BtnSeis.TabIndex = 8;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = true;
            this.BtnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnOcho
            // 
            this.BtnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOcho.Location = new System.Drawing.Point(91, 228);
            this.BtnOcho.Name = "BtnOcho";
            this.BtnOcho.Size = new System.Drawing.Size(65, 45);
            this.BtnOcho.TabIndex = 9;
            this.BtnOcho.Text = "8";
            this.BtnOcho.UseVisualStyleBackColor = true;
            this.BtnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnSiete
            // 
            this.BtnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiete.Location = new System.Drawing.Point(20, 228);
            this.BtnSiete.Name = "BtnSiete";
            this.BtnSiete.Size = new System.Drawing.Size(65, 45);
            this.BtnSiete.TabIndex = 10;
            this.BtnSiete.Text = "7";
            this.BtnSiete.UseVisualStyleBackColor = true;
            this.BtnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnCinco
            // 
            this.BtnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCinco.Location = new System.Drawing.Point(91, 279);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(65, 45);
            this.BtnCinco.TabIndex = 11;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = true;
            this.BtnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuatro.Location = new System.Drawing.Point(20, 279);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(65, 45);
            this.BtnCuatro.TabIndex = 12;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = true;
            this.BtnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnResta
            // 
            this.BtnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.Location = new System.Drawing.Point(253, 279);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(65, 45);
            this.BtnResta.TabIndex = 13;
            this.BtnResta.Tag = "-";
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.Location = new System.Drawing.Point(253, 177);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(65, 45);
            this.BtnDivision.TabIndex = 14;
            this.BtnDivision.Tag = "÷";
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(233, 381);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(85, 45);
            this.BtnIgual.TabIndex = 15;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnMultiplicacion
            // 
            this.BtnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacion.Location = new System.Drawing.Point(253, 228);
            this.BtnMultiplicacion.Name = "BtnMultiplicacion";
            this.BtnMultiplicacion.Size = new System.Drawing.Size(65, 45);
            this.BtnMultiplicacion.TabIndex = 16;
            this.BtnMultiplicacion.Tag = "x";
            this.BtnMultiplicacion.Text = "x";
            this.BtnMultiplicacion.UseVisualStyleBackColor = true;
            this.BtnMultiplicacion.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.Location = new System.Drawing.Point(253, 330);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(65, 45);
            this.BtnSuma.TabIndex = 17;
            this.BtnSuma.Tag = "+";
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnRaizCuadrada
            // 
            this.BtnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRaizCuadrada.Location = new System.Drawing.Point(162, 177);
            this.BtnRaizCuadrada.Name = "BtnRaizCuadrada";
            this.BtnRaizCuadrada.Size = new System.Drawing.Size(65, 45);
            this.BtnRaizCuadrada.TabIndex = 19;
            this.BtnRaizCuadrada.Tag = "√";
            this.BtnRaizCuadrada.Text = " √";
            this.BtnRaizCuadrada.UseVisualStyleBackColor = true;
            this.BtnRaizCuadrada.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnAlCuadrado
            // 
            this.BtnAlCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlCuadrado.Location = new System.Drawing.Point(91, 177);
            this.BtnAlCuadrado.Name = "BtnAlCuadrado";
            this.BtnAlCuadrado.Size = new System.Drawing.Size(65, 45);
            this.BtnAlCuadrado.TabIndex = 20;
            this.BtnAlCuadrado.Tag = "²";
            this.BtnAlCuadrado.Text = "x²";
            this.BtnAlCuadrado.UseVisualStyleBackColor = true;
            this.BtnAlCuadrado.Click += new System.EventHandler(this.OperadorClick);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.Location = new System.Drawing.Point(244, 126);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(74, 45);
            this.BtnQuitar.TabIndex = 21;
            this.BtnQuitar.Text = "←";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnBorrarTodo
            // 
            this.BtnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarTodo.Location = new System.Drawing.Point(173, 126);
            this.BtnBorrarTodo.Name = "BtnBorrarTodo";
            this.BtnBorrarTodo.Size = new System.Drawing.Size(65, 45);
            this.BtnBorrarTodo.TabIndex = 22;
            this.BtnBorrarTodo.Text = "C";
            this.BtnBorrarTodo.UseVisualStyleBackColor = true;
            this.BtnBorrarTodo.Click += new System.EventHandler(this.BtnBorrarTodo_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(91, 126);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(76, 45);
            this.BtnBorrar.TabIndex = 23;
            this.BtnBorrar.Text = "CE";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Btnsubmenu
            // 
            this.Btnsubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsubmenu.Location = new System.Drawing.Point(20, 126);
            this.Btnsubmenu.Name = "Btnsubmenu";
            this.Btnsubmenu.Size = new System.Drawing.Size(65, 96);
            this.Btnsubmenu.TabIndex = 24;
            this.Btnsubmenu.Tag = "≡";
            this.Btnsubmenu.Text = "≡";
            this.Btnsubmenu.UseVisualStyleBackColor = true;
            this.Btnsubmenu.Click += new System.EventHandler(this.Btnsubmenu_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 462);
            this.Controls.Add(this.Btnsubmenu);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnBorrarTodo);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAlCuadrado);
            this.Controls.Add(this.BtnRaizCuadrada);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnMultiplicacion);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnCuatro);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnSiete);
            this.Controls.Add(this.BtnOcho);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnNueve);
            this.Controls.Add(this.BtnPunto);
            this.Controls.Add(this.BtnSigno);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnDos);
            this.Controls.Add(this.BtnUno);
            this.Controls.Add(this.TxtResultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultados;
        private System.Windows.Forms.Button BtnUno;
        private System.Windows.Forms.Button BtnDos;
        private System.Windows.Forms.Button BtnTres;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button BtnSigno;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button BtnNueve;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnOcho;
        private System.Windows.Forms.Button BtnSiete;
        private System.Windows.Forms.Button BtnCinco;
        private System.Windows.Forms.Button BtnCuatro;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnMultiplicacion;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnRaizCuadrada;
        private System.Windows.Forms.Button BtnAlCuadrado;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnBorrarTodo;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button Btnsubmenu;
    }
}

