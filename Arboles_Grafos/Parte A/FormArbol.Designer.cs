namespace Arboles_Grafos
{
    partial class FormArbol
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeArbol = new System.Windows.Forms.TreeView();
            this.lstArbol = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstadoArbol = new System.Windows.Forms.Label();
            this.btnEliminarArbol = new System.Windows.Forms.Button();
            this.btnNivelNodo = new System.Windows.Forms.Button();
            this.btnAlturaArbol = new System.Windows.Forms.Button();
            this.cmbRecorrido = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNivelNodo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jerarquía Organizativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargos de la empresa:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(177, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(213, 26);
            this.txtValor.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(396, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnContar
            // 
            this.btnContar.AutoSize = true;
            this.btnContar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.ForeColor = System.Drawing.Color.White;
            this.btnContar.Location = new System.Drawing.Point(148, 199);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(124, 36);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.AutoSize = true;
            this.btnRecorrido.BackColor = System.Drawing.Color.Salmon;
            this.btnRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrido.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRecorrido.Location = new System.Drawing.Point(244, 150);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(167, 36);
            this.btnRecorrido.TabIndex = 5;
            this.btnRecorrido.Text = "Recorrido InOrden";
            this.btnRecorrido.UseVisualStyleBackColor = false;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(761, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(531, 520);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 36);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 64);
            this.panel1.TabIndex = 8;
            // 
            // treeArbol
            // 
            this.treeArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.treeArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeArbol.ForeColor = System.Drawing.Color.White;
            this.treeArbol.Location = new System.Drawing.Point(12, 252);
            this.treeArbol.Name = "treeArbol";
            this.treeArbol.Size = new System.Drawing.Size(399, 262);
            this.treeArbol.TabIndex = 9;
            this.treeArbol.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeArbol_NodeMouseDoubleClick);
            // 
            // lstArbol
            // 
            this.lstArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.lstArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArbol.ForeColor = System.Drawing.Color.White;
            this.lstArbol.FormattingEnabled = true;
            this.lstArbol.ItemHeight = 18;
            this.lstArbol.Location = new System.Drawing.Point(531, 252);
            this.lstArbol.Name = "lstArbol";
            this.lstArbol.Size = new System.Drawing.Size(354, 256);
            this.lstArbol.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.lblEstadoArbol);
            this.panel2.Location = new System.Drawing.Point(-1, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 64);
            this.panel2.TabIndex = 9;
            // 
            // lblEstadoArbol
            // 
            this.lblEstadoArbol.AutoSize = true;
            this.lblEstadoArbol.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoArbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadoArbol.Location = new System.Drawing.Point(6, 13);
            this.lblEstadoArbol.Name = "lblEstadoArbol";
            this.lblEstadoArbol.Size = new System.Drawing.Size(289, 42);
            this.lblEstadoArbol.TabIndex = 0;
            this.lblEstadoArbol.Text = "Estado: Mensaje aqui...";
            // 
            // btnEliminarArbol
            // 
            this.btnEliminarArbol.AutoSize = true;
            this.btnEliminarArbol.BackColor = System.Drawing.Color.Red;
            this.btnEliminarArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArbol.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArbol.Location = new System.Drawing.Point(12, 520);
            this.btnEliminarArbol.Name = "btnEliminarArbol";
            this.btnEliminarArbol.Size = new System.Drawing.Size(135, 30);
            this.btnEliminarArbol.TabIndex = 11;
            this.btnEliminarArbol.Text = "Eliminar Arbol";
            this.btnEliminarArbol.UseVisualStyleBackColor = false;
            this.btnEliminarArbol.Click += new System.EventHandler(this.btnEliminarArbol_Click);
            // 
            // btnNivelNodo
            // 
            this.btnNivelNodo.AutoSize = true;
            this.btnNivelNodo.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnNivelNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivelNodo.ForeColor = System.Drawing.Color.White;
            this.btnNivelNodo.Location = new System.Drawing.Point(699, 150);
            this.btnNivelNodo.Name = "btnNivelNodo";
            this.btnNivelNodo.Size = new System.Drawing.Size(133, 36);
            this.btnNivelNodo.TabIndex = 13;
            this.btnNivelNodo.Text = "Nivel del nodo";
            this.btnNivelNodo.UseVisualStyleBackColor = false;
            this.btnNivelNodo.Click += new System.EventHandler(this.btnNivelNodo_Click);
            // 
            // btnAlturaArbol
            // 
            this.btnAlturaArbol.AutoSize = true;
            this.btnAlturaArbol.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAlturaArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlturaArbol.ForeColor = System.Drawing.Color.White;
            this.btnAlturaArbol.Location = new System.Drawing.Point(505, 199);
            this.btnAlturaArbol.Name = "btnAlturaArbol";
            this.btnAlturaArbol.Size = new System.Drawing.Size(150, 36);
            this.btnAlturaArbol.TabIndex = 14;
            this.btnAlturaArbol.Text = "Niveles del arbol";
            this.btnAlturaArbol.UseVisualStyleBackColor = false;
            this.btnAlturaArbol.Click += new System.EventHandler(this.btnAlturaArbol_Click);
            // 
            // cmbRecorrido
            // 
            this.cmbRecorrido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecorrido.FormattingEnabled = true;
            this.cmbRecorrido.Items.AddRange(new object[] {
            "InOrden",
            "PreOrden",
            "PostOrden",
            "Por niveles"});
            this.cmbRecorrido.Location = new System.Drawing.Point(24, 160);
            this.cmbRecorrido.Name = "cmbRecorrido";
            this.cmbRecorrido.Size = new System.Drawing.Size(203, 21);
            this.cmbRecorrido.TabIndex = 15;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(547, 98);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 26);
            this.txtBuscar.TabIndex = 16;
            // 
            // txtNivelNodo
            // 
            this.txtNivelNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelNodo.Location = new System.Drawing.Point(475, 155);
            this.txtNivelNodo.Name = "txtNivelNodo";
            this.txtNivelNodo.Size = new System.Drawing.Size(208, 26);
            this.txtNivelNodo.TabIndex = 17;
            // 
            // FormArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(897, 636);
            this.Controls.Add(this.txtNivelNodo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbRecorrido);
            this.Controls.Add(this.btnAlturaArbol);
            this.Controls.Add(this.btnNivelNodo);
            this.Controls.Add(this.btnEliminarArbol);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstArbol);
            this.Controls.Add(this.treeArbol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Name = "FormArbol";
            this.Text = "FormArbol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeArbol;
        private System.Windows.Forms.ListBox lstArbol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEstadoArbol;
        private System.Windows.Forms.Button btnEliminarArbol;
        private System.Windows.Forms.Button btnNivelNodo;
        private System.Windows.Forms.Button btnAlturaArbol;
        private System.Windows.Forms.ComboBox cmbRecorrido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNivelNodo;
    }
}