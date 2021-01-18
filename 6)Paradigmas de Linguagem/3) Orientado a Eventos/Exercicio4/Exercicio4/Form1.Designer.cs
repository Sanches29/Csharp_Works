namespace Exercicio4
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlPainel = new System.Windows.Forms.Panel();
            this.btnCor = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPainel
            // 
            this.pnlPainel.BackColor = System.Drawing.Color.White;
            this.pnlPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPainel.Controls.Add(this.btnLimpar);
            this.pnlPainel.Controls.Add(this.btnCor);
            this.pnlPainel.Location = new System.Drawing.Point(0, -2);
            this.pnlPainel.Name = "pnlPainel";
            this.pnlPainel.Size = new System.Drawing.Size(524, 304);
            this.pnlPainel.TabIndex = 0;
            this.pnlPainel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPainel_Paint);
            this.pnlPainel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPainel_MouseDown);
            this.pnlPainel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPainel_MouseMove);
            this.pnlPainel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPainel_MouseUp);
            // 
            // btnCor
            // 
            this.btnCor.BackColor = System.Drawing.Color.Black;
            this.btnCor.Location = new System.Drawing.Point(3, 3);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(87, 20);
            this.btnCor.TabIndex = 1;
            this.btnCor.UseVisualStyleBackColor = false;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(105, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 20);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 305);
            this.Controls.Add(this.pnlPainel);
            this.Name = "Form1";
            this.Text = "Exercicio4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPainel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlPainel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCor;
    }
}

