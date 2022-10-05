namespace FIGURRAAAA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPiramide = new System.Windows.Forms.Button();
            this.btnCubo = new System.Windows.Forms.Button();
            this.btnEsfera = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 136);
            this.button1.TabIndex = 0;
            this.button1.Text = "noseCuadrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora de figuras geometricas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 136);
            this.button2.TabIndex = 4;
            this.button2.Text = "tringculos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(489, 27);
            this.btnCirculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(181, 136);
            this.btnCirculo.TabIndex = 5;
            this.btnCirculo.Text = "circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCirculo);
            this.groupBox1.Location = new System.Drawing.Point(70, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figuras Bidimencionales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPiramide);
            this.groupBox2.Controls.Add(this.btnCubo);
            this.groupBox2.Controls.Add(this.btnEsfera);
            this.groupBox2.Location = new System.Drawing.Point(70, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 144);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figuras Tridimencionales";
            // 
            // btnPiramide
            // 
            this.btnPiramide.Location = new System.Drawing.Point(489, 24);
            this.btnPiramide.Name = "btnPiramide";
            this.btnPiramide.Size = new System.Drawing.Size(181, 97);
            this.btnPiramide.TabIndex = 2;
            this.btnPiramide.Text = "Piramide";
            this.btnPiramide.UseVisualStyleBackColor = true;
            this.btnPiramide.Click += new System.EventHandler(this.btnPiramide_Click);
            // 
            // btnCubo
            // 
            this.btnCubo.Location = new System.Drawing.Point(264, 24);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(181, 97);
            this.btnCubo.TabIndex = 1;
            this.btnCubo.Text = "Cubo";
            this.btnCubo.UseVisualStyleBackColor = true;
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);
            // 
            // btnEsfera
            // 
            this.btnEsfera.Location = new System.Drawing.Point(50, 26);
            this.btnEsfera.Name = "btnEsfera";
            this.btnEsfera.Size = new System.Drawing.Size(181, 97);
            this.btnEsfera.TabIndex = 0;
            this.btnEsfera.Text = "Esfera ";
            this.btnEsfera.UseVisualStyleBackColor = true;
            this.btnEsfera.Click += new System.EventHandler(this.btnEsfera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button btnCirculo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnPiramide;
        private Button btnCubo;
        private Button btnEsfera;
    }
}