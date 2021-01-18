namespace QuizzForms
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
            this.checklstboxAlternativas = new System.Windows.Forms.CheckedListBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checklstboxAlternativas
            // 
            this.checklstboxAlternativas.BackColor = System.Drawing.SystemColors.Control;
            this.checklstboxAlternativas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checklstboxAlternativas.CheckOnClick = true;
            this.checklstboxAlternativas.FormattingEnabled = true;
            this.checklstboxAlternativas.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.checklstboxAlternativas.Location = new System.Drawing.Point(12, 183);
            this.checklstboxAlternativas.Name = "checklstboxAlternativas";
            this.checklstboxAlternativas.Size = new System.Drawing.Size(63, 90);
            this.checklstboxAlternativas.TabIndex = 0;
            this.checklstboxAlternativas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklstboxAlternativas_ItemCheck);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(216, 253);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 2;
            this.btnAvancar.TabStop = false;
            this.btnAvancar.Text = "Confirmar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // rtxt1
            // 
            this.rtxt1.Location = new System.Drawing.Point(12, 12);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(311, 151);
            this.rtxt1.TabIndex = 1;
            this.rtxt1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(332, 308);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.checklstboxAlternativas);
            this.Name = "Form1";
            this.Text = "QuizzForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklstboxAlternativas;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.RichTextBox rtxt1;
    }
}

