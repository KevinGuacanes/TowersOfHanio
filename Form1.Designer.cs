namespace TorresHanio
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNmin = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.btnSolucion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTorre3 = new System.Windows.Forms.Label();
            this.lblTorre2 = new System.Windows.Forms.Label();
            this.lblTorre1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(69, 50);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 0;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(209, 48);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(100, 23);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Objetivo de numero de movimientos:";
            // 
            // lblNmin
            // 
            this.lblNmin.AutoSize = true;
            this.lblNmin.Location = new System.Drawing.Point(590, 57);
            this.lblNmin.Name = "lblNmin";
            this.lblNmin.Size = new System.Drawing.Size(13, 13);
            this.lblNmin.TabIndex = 12;
            this.lblNmin.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(303, 447);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(418, 447);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(75, 23);
            this.btnComprobar.TabIndex = 14;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // btnSolucion
            // 
            this.btnSolucion.Location = new System.Drawing.Point(542, 447);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.Size = new System.Drawing.Size(75, 23);
            this.btnSolucion.TabIndex = 16;
            this.btnSolucion.Text = "Solucion";
            this.btnSolucion.UseVisualStyleBackColor = true;
            this.btnSolucion.Click += new System.EventHandler(this.btnSolucion_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(719, 48);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblTorre3
            // 
            this.lblTorre3.AutoSize = true;
            this.lblTorre3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorre3.Location = new System.Drawing.Point(745, 411);
            this.lblTorre3.Name = "lblTorre3";
            this.lblTorre3.Size = new System.Drawing.Size(64, 20);
            this.lblTorre3.TabIndex = 20;
            this.lblTorre3.Text = "Torre3";
            // 
            // lblTorre2
            // 
            this.lblTorre2.AutoSize = true;
            this.lblTorre2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorre2.Location = new System.Drawing.Point(430, 411);
            this.lblTorre2.Name = "lblTorre2";
            this.lblTorre2.Size = new System.Drawing.Size(63, 20);
            this.lblTorre2.TabIndex = 21;
            this.lblTorre2.Text = "Torre2";
            // 
            // lblTorre1
            // 
            this.lblTorre1.AutoSize = true;
            this.lblTorre1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorre1.Location = new System.Drawing.Point(131, 411);
            this.lblTorre1.Name = "lblTorre1";
            this.lblTorre1.Size = new System.Drawing.Size(61, 20);
            this.lblTorre1.TabIndex = 22;
            this.lblTorre1.Text = "Torre1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Brush Script MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(332, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 36);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Torres de Hanoi";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(716, 15);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 24;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numero discos: 1-10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTorre1);
            this.Controls.Add(this.lblTorre2);
            this.Controls.Add(this.lblTorre3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnSolucion);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblNmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txtTamaño);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNmin;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Button btnSolucion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblTorre3;
        private System.Windows.Forms.Label lblTorre2;
        private System.Windows.Forms.Label lblTorre1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label2;
    }
}

