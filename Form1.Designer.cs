namespace CalcularCapacidad
{
    partial class CalcularCapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularCapacidad));
            this.ckCubo = new System.Windows.Forms.CheckBox();
            this.ckPrismaRectangular = new System.Windows.Forms.CheckBox();
            this.ckPrismaCuadrangular = new System.Windows.Forms.CheckBox();
            this.ckCilindro = new System.Windows.Forms.CheckBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtAltura2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckCubo
            // 
            this.ckCubo.AutoSize = true;
            this.ckCubo.Location = new System.Drawing.Point(119, 34);
            this.ckCubo.Name = "ckCubo";
            this.ckCubo.Size = new System.Drawing.Size(61, 20);
            this.ckCubo.TabIndex = 0;
            this.ckCubo.Text = "Cubo";
            this.ckCubo.UseVisualStyleBackColor = true;
            // 
            // ckPrismaRectangular
            // 
            this.ckPrismaRectangular.AutoSize = true;
            this.ckPrismaRectangular.Location = new System.Drawing.Point(119, 76);
            this.ckPrismaRectangular.Name = "ckPrismaRectangular";
            this.ckPrismaRectangular.Size = new System.Drawing.Size(147, 20);
            this.ckPrismaRectangular.TabIndex = 1;
            this.ckPrismaRectangular.Text = "Prisma Rectangular";
            this.ckPrismaRectangular.UseVisualStyleBackColor = true;
            // 
            // ckPrismaCuadrangular
            // 
            this.ckPrismaCuadrangular.AutoSize = true;
            this.ckPrismaCuadrangular.Location = new System.Drawing.Point(119, 127);
            this.ckPrismaCuadrangular.Name = "ckPrismaCuadrangular";
            this.ckPrismaCuadrangular.Size = new System.Drawing.Size(155, 20);
            this.ckPrismaCuadrangular.TabIndex = 2;
            this.ckPrismaCuadrangular.Text = "Prisma Cuadrangular";
            this.ckPrismaCuadrangular.UseVisualStyleBackColor = true;
            // 
            // ckCilindro
            // 
            this.ckCilindro.AutoSize = true;
            this.ckCilindro.Location = new System.Drawing.Point(119, 177);
            this.ckCilindro.Name = "ckCilindro";
            this.ckCilindro.Size = new System.Drawing.Size(74, 20);
            this.ckCilindro.TabIndex = 3;
            this.ckCilindro.Text = "Cilindro";
            this.ckCilindro.UseVisualStyleBackColor = true;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(119, 246);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(119, 274);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 5;
            // 
            // txtAltura2
            // 
            this.txtAltura2.Location = new System.Drawing.Point(119, 302);
            this.txtAltura2.Name = "txtAltura2";
            this.txtAltura2.Size = new System.Drawing.Size(100, 22);
            this.txtAltura2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "altura2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular Capacidad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 185);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "V = AreaBase * Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "AreaBase = Base * Altura";
            // 
            // CalcularCapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.ckCilindro);
            this.Controls.Add(this.ckPrismaCuadrangular);
            this.Controls.Add(this.ckPrismaRectangular);
            this.Controls.Add(this.ckCubo);
            this.Name = "CalcularCapacidad";
            this.Text = "Calcular Capacidad";
            this.Load += new System.EventHandler(this.CalcularCapacidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckCubo;
        private System.Windows.Forms.CheckBox ckPrismaRectangular;
        private System.Windows.Forms.CheckBox ckPrismaCuadrangular;
        private System.Windows.Forms.CheckBox ckCilindro;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtAltura2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

