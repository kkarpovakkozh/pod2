namespace prepare
{
    partial class uchastnik
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
            this.avtorizacia = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.TextBox();
            this.reglogin = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.registrcia = new System.Windows.Forms.Button();
            this.regrepass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // avtorizacia
            // 
            this.avtorizacia.Location = new System.Drawing.Point(77, 249);
            this.avtorizacia.Name = "avtorizacia";
            this.avtorizacia.Size = new System.Drawing.Size(128, 39);
            this.avtorizacia.TabIndex = 0;
            this.avtorizacia.Text = "avtorizacia";
            this.avtorizacia.UseVisualStyleBackColor = true;
            this.avtorizacia.Click += new System.EventHandler(this.avtorizacia_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(77, 129);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(128, 22);
            this.log.TabIndex = 1;
            // 
            // pas
            // 
            this.pas.Location = new System.Drawing.Point(77, 199);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(128, 22);
            this.pas.TabIndex = 2;
            // 
            // reglogin
            // 
            this.reglogin.Location = new System.Drawing.Point(382, 129);
            this.reglogin.Name = "reglogin";
            this.reglogin.Size = new System.Drawing.Size(128, 22);
            this.reglogin.TabIndex = 3;
            // 
            // regpass
            // 
            this.regpass.Location = new System.Drawing.Point(382, 199);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(128, 22);
            this.regpass.TabIndex = 4;
            // 
            // registrcia
            // 
            this.registrcia.Location = new System.Drawing.Point(382, 305);
            this.registrcia.Name = "registrcia";
            this.registrcia.Size = new System.Drawing.Size(128, 39);
            this.registrcia.TabIndex = 5;
            this.registrcia.Text = "registrcia";
            this.registrcia.UseVisualStyleBackColor = true;
            this.registrcia.Click += new System.EventHandler(this.registrcia_Click);
            // 
            // regrepass
            // 
            this.regrepass.Location = new System.Drawing.Point(382, 257);
            this.regrepass.Name = "regrepass";
            this.regrepass.Size = new System.Drawing.Size(128, 22);
            this.regrepass.TabIndex = 6;
            // 
            // uchastnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.regrepass);
            this.Controls.Add(this.registrcia);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.reglogin);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.log);
            this.Controls.Add(this.avtorizacia);
            this.Name = "uchastnik";
            this.Text = "uchastnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avtorizacia;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.TextBox reglogin;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.Button registrcia;
        private System.Windows.Forms.TextBox regrepass;
    }
}