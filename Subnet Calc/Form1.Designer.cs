namespace Subnet_Calc
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
            this.bit1 = new System.Windows.Forms.TextBox();
            this.dot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bit2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bit3 = new System.Windows.Forms.TextBox();
            this.bit4 = new System.Windows.Forms.TextBox();
            this.iplabel = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.subnetbit = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.outputlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bit1
            // 
            this.bit1.Location = new System.Drawing.Point(86, 13);
            this.bit1.MaxLength = 3;
            this.bit1.Name = "bit1";
            this.bit1.Size = new System.Drawing.Size(40, 20);
            this.bit1.TabIndex = 1;
            this.bit1.TextChanged += new System.EventHandler(this.bit1_TextChanged);
            // 
            // dot
            // 
            this.dot.AutoSize = true;
            this.dot.CausesValidation = false;
            this.dot.Enabled = false;
            this.dot.Location = new System.Drawing.Point(128, 20);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(10, 13);
            this.dot.TabIndex = 0;
            this.dot.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(182, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ".";
            // 
            // bit2
            // 
            this.bit2.Location = new System.Drawing.Point(140, 13);
            this.bit2.MaxLength = 3;
            this.bit2.Name = "bit2";
            this.bit2.Size = new System.Drawing.Size(40, 20);
            this.bit2.TabIndex = 2;
            this.bit2.TextChanged += new System.EventHandler(this.bit2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = ".";
            // 
            // bit3
            // 
            this.bit3.Location = new System.Drawing.Point(194, 13);
            this.bit3.MaxLength = 3;
            this.bit3.Name = "bit3";
            this.bit3.Size = new System.Drawing.Size(40, 20);
            this.bit3.TabIndex = 3;
            this.bit3.TextChanged += new System.EventHandler(this.bit3_TextChanged);
            // 
            // bit4
            // 
            this.bit4.Location = new System.Drawing.Point(248, 13);
            this.bit4.MaxLength = 3;
            this.bit4.Name = "bit4";
            this.bit4.Size = new System.Drawing.Size(40, 20);
            this.bit4.TabIndex = 4;
            this.bit4.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Location = new System.Drawing.Point(12, 16);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(67, 13);
            this.iplabel.TabIndex = 0;
            this.iplabel.Text = "IP Address : ";
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.CausesValidation = false;
            this.slash.Location = new System.Drawing.Point(292, 16);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(12, 13);
            this.slash.TabIndex = 0;
            this.slash.Text = "/";
            // 
            // subnetbit
            // 
            this.subnetbit.Location = new System.Drawing.Point(308, 13);
            this.subnetbit.MaxLength = 2;
            this.subnetbit.Name = "subnetbit";
            this.subnetbit.Size = new System.Drawing.Size(30, 20);
            this.subnetbit.TabIndex = 5;
            this.subnetbit.TextChanged += new System.EventHandler(this.subnetbit_TextChanged);
            // 
            // outputbox
            // 
            this.outputbox.CausesValidation = false;
            this.outputbox.Location = new System.Drawing.Point(15, 56);
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.Size = new System.Drawing.Size(323, 193);
            this.outputbox.TabIndex = 0;
            this.outputbox.TabStop = false;
            this.outputbox.Text = "";
            // 
            // outputlab
            // 
            this.outputlab.AutoSize = true;
            this.outputlab.Location = new System.Drawing.Point(12, 40);
            this.outputlab.Name = "outputlab";
            this.outputlab.Size = new System.Drawing.Size(48, 13);
            this.outputlab.TabIndex = 0;
            this.outputlab.Text = "Output : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.outputlab);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.subnetbit);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.bit4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bit3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bit2);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.bit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Subnet Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bit1;
        private System.Windows.Forms.Label dot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bit3;
        private System.Windows.Forms.TextBox bit4;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.TextBox subnetbit;
        private System.Windows.Forms.RichTextBox outputbox;
        private System.Windows.Forms.Label outputlab;
    }
}

