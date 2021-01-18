namespace Exercicio2
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
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.txtResultadoAnalise = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(579, 43);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(105, 23);
            this.btnSelecionarArquivo.TabIndex = 0;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomeArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeArquivo.Location = new System.Drawing.Point(81, 43);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(492, 23);
            this.lblNomeArquivo.TabIndex = 1;
            this.lblNomeArquivo.Text = "<Nenhum arquivo selecionado>";
            this.lblNomeArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(81, 76);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(603, 40);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtResultadoAnalise
            // 
            this.txtResultadoAnalise.Location = new System.Drawing.Point(81, 122);
            this.txtResultadoAnalise.Multiline = true;
            this.txtResultadoAnalise.Name = "txtResultadoAnalise";
            this.txtResultadoAnalise.Size = new System.Drawing.Size(603, 200);
            this.txtResultadoAnalise.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 334);
            this.Controls.Add(this.txtResultadoAnalise);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Exercicio2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.TextBox txtResultadoAnalise;
    }
}

