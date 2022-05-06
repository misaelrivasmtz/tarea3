namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtValorEstatura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtValorPeso = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.picTablaDatos = new System.Windows.Forms.PictureBox();
            this.grpTabla = new System.Windows.Forms.GroupBox();
            this.picBarra = new System.Windows.Forms.PictureBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblObesidadA = new System.Windows.Forms.Label();
            this.lblObesidadB = new System.Windows.Forms.Label();
            this.lblObesidadC = new System.Windows.Forms.Label();
            this.grpBarraColores = new System.Windows.Forms.GroupBox();
            this.lblSobrepeso = new System.Windows.Forms.Label();
            this.btnEndocrinologia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picTablaDatos)).BeginInit();
            this.grpTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBarra)).BeginInit();
            this.grpBarraColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstatura
            // 
            this.lblEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEstatura.Location = new System.Drawing.Point(8, 17);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(65, 17);
            this.lblEstatura.TabIndex = 0;
            this.lblEstatura.Text = "Estatura";
            // 
            // txtValorEstatura
            // 
            this.txtValorEstatura.Location = new System.Drawing.Point(8, 37);
            this.txtValorEstatura.Name = "txtValorEstatura";
            this.txtValorEstatura.Size = new System.Drawing.Size(156, 20);
            this.txtValorEstatura.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPeso.Location = new System.Drawing.Point(8, 74);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(65, 17);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso\r\n";
            // 
            // txtValorPeso
            // 
            this.txtValorPeso.Location = new System.Drawing.Point(8, 94);
            this.txtValorPeso.Name = "txtValorPeso";
            this.txtValorPeso.Size = new System.Drawing.Size(156, 20);
            this.txtValorPeso.TabIndex = 3;
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(8, 129);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(120, 38);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // picTablaDatos
            // 
            this.picTablaDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTablaDatos.Image = ((System.Drawing.Image) (resources.GetObject("picTablaDatos.Image")));
            this.picTablaDatos.Location = new System.Drawing.Point(236, 221);
            this.picTablaDatos.Name = "picTablaDatos";
            this.picTablaDatos.Size = new System.Drawing.Size(617, 199);
            this.picTablaDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTablaDatos.TabIndex = 5;
            this.picTablaDatos.TabStop = false;
            // 
            // grpTabla
            // 
            this.grpTabla.BackColor = System.Drawing.Color.PowderBlue;
            this.grpTabla.Controls.Add(this.btnResultado);
            this.grpTabla.Controls.Add(this.txtValorPeso);
            this.grpTabla.Controls.Add(this.lblPeso);
            this.grpTabla.Controls.Add(this.txtValorEstatura);
            this.grpTabla.Controls.Add(this.lblEstatura);
            this.grpTabla.Location = new System.Drawing.Point(4, 2);
            this.grpTabla.Name = "grpTabla";
            this.grpTabla.Size = new System.Drawing.Size(213, 197);
            this.grpTabla.TabIndex = 6;
            this.grpTabla.TabStop = false;
            // 
            // picBarra
            // 
            this.picBarra.BackColor = System.Drawing.Color.Transparent;
            this.picBarra.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("picBarra.BackgroundImage")));
            this.picBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBarra.Location = new System.Drawing.Point(-11, 114);
            this.picBarra.Name = "picBarra";
            this.picBarra.Size = new System.Drawing.Size(686, 40);
            this.picBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBarra.TabIndex = 7;
            this.picBarra.TabStop = false;
            // 
            // lblBP
            // 
            this.lblBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBP.ForeColor = System.Drawing.Color.White;
            this.lblBP.Location = new System.Drawing.Point(21, 85);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(86, 25);
            this.lblBP.TabIndex = 8;
            this.lblBP.Text = "Bajo Peso";
            this.lblBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNormal
            // 
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNormal.ForeColor = System.Drawing.Color.White;
            this.lblNormal.Location = new System.Drawing.Point(135, 85);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(86, 25);
            this.lblNormal.TabIndex = 9;
            this.lblNormal.Text = "Normal";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObesidadA
            // 
            this.lblObesidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObesidadA.ForeColor = System.Drawing.Color.White;
            this.lblObesidadA.Location = new System.Drawing.Point(354, 76);
            this.lblObesidadA.Name = "lblObesidadA";
            this.lblObesidadA.Size = new System.Drawing.Size(86, 34);
            this.lblObesidadA.TabIndex = 11;
            this.lblObesidadA.Text = "Obesidad\r\nClase 1";
            this.lblObesidadA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObesidadB
            // 
            this.lblObesidadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObesidadB.ForeColor = System.Drawing.Color.White;
            this.lblObesidadB.Location = new System.Drawing.Point(468, 80);
            this.lblObesidadB.Name = "lblObesidadB";
            this.lblObesidadB.Size = new System.Drawing.Size(86, 34);
            this.lblObesidadB.TabIndex = 12;
            this.lblObesidadB.Text = "Obesidad\r\nClase 2";
            this.lblObesidadB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObesidadC
            // 
            this.lblObesidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObesidadC.ForeColor = System.Drawing.Color.White;
            this.lblObesidadC.Location = new System.Drawing.Point(576, 76);
            this.lblObesidadC.Name = "lblObesidadC";
            this.lblObesidadC.Size = new System.Drawing.Size(86, 34);
            this.lblObesidadC.TabIndex = 13;
            this.lblObesidadC.Text = "Obesidad\r\nClase 3";
            this.lblObesidadC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBarraColores
            // 
            this.grpBarraColores.BackColor = System.Drawing.Color.RoyalBlue;
            this.grpBarraColores.Controls.Add(this.lblSobrepeso);
            this.grpBarraColores.Controls.Add(this.lblObesidadB);
            this.grpBarraColores.Controls.Add(this.lblObesidadC);
            this.grpBarraColores.Controls.Add(this.lblObesidadA);
            this.grpBarraColores.Controls.Add(this.picBarra);
            this.grpBarraColores.Controls.Add(this.lblNormal);
            this.grpBarraColores.Controls.Add(this.lblBP);
            this.grpBarraColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBarraColores.Location = new System.Drawing.Point(215, 2);
            this.grpBarraColores.Name = "grpBarraColores";
            this.grpBarraColores.Size = new System.Drawing.Size(675, 197);
            this.grpBarraColores.TabIndex = 14;
            this.grpBarraColores.TabStop = false;
            // 
            // lblSobrepeso
            // 
            this.lblSobrepeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSobrepeso.ForeColor = System.Drawing.Color.White;
            this.lblSobrepeso.Location = new System.Drawing.Point(238, 85);
            this.lblSobrepeso.Name = "lblSobrepeso";
            this.lblSobrepeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSobrepeso.Size = new System.Drawing.Size(110, 26);
            this.lblSobrepeso.TabIndex = 14;
            this.lblSobrepeso.Text = "Sobrepeso";
            this.lblSobrepeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEndocrinologia
            // 
            this.btnEndocrinologia.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEndocrinologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEndocrinologia.ForeColor = System.Drawing.Color.White;
            this.btnEndocrinologia.Location = new System.Drawing.Point(33, 262);
            this.btnEndocrinologia.Name = "btnEndocrinologia";
            this.btnEndocrinologia.Size = new System.Drawing.Size(146, 48);
            this.btnEndocrinologia.TabIndex = 15;
            this.btnEndocrinologia.Text = "Ir a Endocrinología";
            this.btnEndocrinologia.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnEndocrinologia);
            this.Controls.Add(this.grpBarraColores);
            this.Controls.Add(this.grpTabla);
            this.Controls.Add(this.picTablaDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.picTablaDatos)).EndInit();
            this.grpTabla.ResumeLayout(false);
            this.grpTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBarra)).EndInit();
            this.grpBarraColores.ResumeLayout(false);
            this.grpBarraColores.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEndocrinologia;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lblSobrepeso;

        private System.Windows.Forms.GroupBox grpBarraColores;

        private System.Windows.Forms.Label lblObesidadC;

        private System.Windows.Forms.Label lblObesidadB;

        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblObesidadA;

        private System.Windows.Forms.Label lblBP;

        private System.Windows.Forms.PictureBox picBarra;

        private System.Windows.Forms.GroupBox grpTabla;

        private System.Windows.Forms.PictureBox picTablaDatos;

        private System.Windows.Forms.TextBox txtValorPeso;
        private System.Windows.Forms.Button btnResultado;

        private System.Windows.Forms.Label lblPeso;

        private System.Windows.Forms.TextBox txtValorEstatura;

        private System.Windows.Forms.Label lblEstatura;

        #endregion
    }
}