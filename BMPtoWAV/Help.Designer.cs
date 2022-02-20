namespace VinylDraw
{
    partial class Help
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
            this.txtHelp1 = new System.Windows.Forms.TextBox();
            this.txtHelp2 = new System.Windows.Forms.TextBox();
            this.txtHelp4 = new System.Windows.Forms.TextBox();
            this.txtHelp5 = new System.Windows.Forms.TextBox();
            this.txtHelp3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHelp1
            // 
            this.txtHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp1.Location = new System.Drawing.Point(12, 11);
            this.txtHelp1.Multiline = true;
            this.txtHelp1.Name = "txtHelp1";
            this.txtHelp1.ReadOnly = true;
            this.txtHelp1.Size = new System.Drawing.Size(854, 78);
            this.txtHelp1.TabIndex = 0;
            this.txtHelp1.TabStop = false;
            // 
            // txtHelp2
            // 
            this.txtHelp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp2.Location = new System.Drawing.Point(12, 95);
            this.txtHelp2.Multiline = true;
            this.txtHelp2.Name = "txtHelp2";
            this.txtHelp2.ReadOnly = true;
            this.txtHelp2.Size = new System.Drawing.Size(854, 164);
            this.txtHelp2.TabIndex = 1;
            this.txtHelp2.TabStop = false;
            // 
            // txtHelp4
            // 
            this.txtHelp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp4.Location = new System.Drawing.Point(12, 334);
            this.txtHelp4.Multiline = true;
            this.txtHelp4.Name = "txtHelp4";
            this.txtHelp4.ReadOnly = true;
            this.txtHelp4.Size = new System.Drawing.Size(854, 150);
            this.txtHelp4.TabIndex = 2;
            this.txtHelp4.TabStop = false;
            // 
            // txtHelp5
            // 
            this.txtHelp5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp5.Location = new System.Drawing.Point(12, 490);
            this.txtHelp5.Multiline = true;
            this.txtHelp5.Name = "txtHelp5";
            this.txtHelp5.ReadOnly = true;
            this.txtHelp5.Size = new System.Drawing.Size(854, 35);
            this.txtHelp5.TabIndex = 3;
            this.txtHelp5.TabStop = false;
            // 
            // txtHelp3
            // 
            this.txtHelp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp3.Location = new System.Drawing.Point(12, 265);
            this.txtHelp3.Multiline = true;
            this.txtHelp3.Name = "txtHelp3";
            this.txtHelp3.ReadOnly = true;
            this.txtHelp3.Size = new System.Drawing.Size(854, 63);
            this.txtHelp3.TabIndex = 4;
            this.txtHelp3.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.txtHelp3);
            this.Controls.Add(this.txtHelp5);
            this.Controls.Add(this.txtHelp4);
            this.Controls.Add(this.txtHelp2);
            this.Controls.Add(this.txtHelp1);
            this.Name = "Help";
            this.Text = "Vinyl Draw - Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHelp1;
        private System.Windows.Forms.TextBox txtHelp2;
        private System.Windows.Forms.TextBox txtHelp4;
        private System.Windows.Forms.TextBox txtHelp5;
        private System.Windows.Forms.TextBox txtHelp3;
    }
}