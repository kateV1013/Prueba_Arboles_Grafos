namespace Arboles_Grafos
{
    partial class FormGrafos
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
            this.lblEstadoGrafo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.txtDestinoRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrigenRuta = new System.Windows.Forms.TextBox();
            this.lstGrafos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrarConexiones = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdificioOrigen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdificioDestino = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.lblEstadoGrafo);
            this.panel1.Location = new System.Drawing.Point(-6, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 64);
            this.panel1.TabIndex = 9;
            // 
            // lblEstadoGrafo
            // 
            this.lblEstadoGrafo.AutoSize = true;
            this.lblEstadoGrafo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoGrafo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadoGrafo.Location = new System.Drawing.Point(15, 13);
            this.lblEstadoGrafo.Name = "lblEstadoGrafo";
            this.lblEstadoGrafo.Size = new System.Drawing.Size(294, 42);
            this.lblEstadoGrafo.TabIndex = 0;
            this.lblEstadoGrafo.Text = "Estado: Mensaje Aqui...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-6, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 73);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(197, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema de Rutas del Parque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre del Edificio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edificio origen:";
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(12, 122);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(204, 20);
            this.txtEdificio.TabIndex = 12;
            // 
            // txtDestinoRuta
            // 
            this.txtDestinoRuta.Location = new System.Drawing.Point(157, 270);
            this.txtDestinoRuta.Name = "txtDestinoRuta";
            this.txtDestinoRuta.Size = new System.Drawing.Size(186, 20);
            this.txtDestinoRuta.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registar rutas entre edificios";
            // 
            // txtOrigenRuta
            // 
            this.txtOrigenRuta.Location = new System.Drawing.Point(157, 229);
            this.txtOrigenRuta.Name = "txtOrigenRuta";
            this.txtOrigenRuta.Size = new System.Drawing.Size(186, 20);
            this.txtOrigenRuta.TabIndex = 15;
            // 
            // lstGrafos
            // 
            this.lstGrafos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.lstGrafos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGrafos.ForeColor = System.Drawing.Color.White;
            this.lstGrafos.FormattingEnabled = true;
            this.lstGrafos.ItemHeight = 18;
            this.lstGrafos.Location = new System.Drawing.Point(452, 111);
            this.lstGrafos.Name = "lstGrafos";
            this.lstGrafos.Size = new System.Drawing.Size(269, 346);
            this.lstGrafos.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Purple;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(229, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 33);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edificio destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Distancia(m):";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(157, 314);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(186, 20);
            this.txtDistancia.TabIndex = 25;
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.Location = new System.Drawing.Point(93, 355);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(176, 34);
            this.btnRuta.TabIndex = 26;
            this.btnRuta.Text = "Agregar ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(466, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Edificios y rutas registradas";
            // 
            // btnMostrarConexiones
            // 
            this.btnMostrarConexiones.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMostrarConexiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarConexiones.Location = new System.Drawing.Point(460, 482);
            this.btnMostrarConexiones.Name = "btnMostrarConexiones";
            this.btnMostrarConexiones.Size = new System.Drawing.Size(109, 53);
            this.btnMostrarConexiones.TabIndex = 28;
            this.btnMostrarConexiones.Text = "Mostrar conexiones";
            this.btnMostrarConexiones.UseVisualStyleBackColor = false;
            this.btnMostrarConexiones.Click += new System.EventHandler(this.btnMostrarConexiones_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Calcular ruta más corta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Edificio origen:";
            // 
            // txtEdificioOrigen
            // 
            this.txtEdificioOrigen.Location = new System.Drawing.Point(157, 457);
            this.txtEdificioOrigen.Name = "txtEdificioOrigen";
            this.txtEdificioOrigen.Size = new System.Drawing.Size(186, 20);
            this.txtEdificioOrigen.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Edificio destino:";
            // 
            // txtEdificioDestino
            // 
            this.txtEdificioDestino.Location = new System.Drawing.Point(157, 500);
            this.txtEdificioDestino.Name = "txtEdificioDestino";
            this.txtEdificioDestino.Size = new System.Drawing.Size(186, 20);
            this.txtEdificioDestino.TabIndex = 33;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(180, 526);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(145, 33);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTodo.Location = new System.Drawing.Point(601, 482);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(109, 53);
            this.btnEliminarTodo.TabIndex = 35;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // FormGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(733, 639);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtEdificioDestino);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEdificioOrigen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMostrarConexiones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstGrafos);
            this.Controls.Add(this.txtOrigenRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestinoRuta);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrafos";
            this.Text = "FormGrafos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstadoGrafo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.TextBox txtDestinoRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigenRuta;
        private System.Windows.Forms.ListBox lstGrafos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrarConexiones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdificioOrigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdificioDestino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminarTodo;
    }
}