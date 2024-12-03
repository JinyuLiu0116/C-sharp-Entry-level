namespace HW8
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
            this.tb_firstN = new System.Windows.Forms.TextBox();
            this.tb_lastN = new System.Windows.Forms.TextBox();
            this.lb_first = new System.Windows.Forms.Label();
            this.lb_last = new System.Windows.Forms.Label();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_firstN
            // 
            this.tb_firstN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_firstN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_firstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstN.Location = new System.Drawing.Point(203, 29);
            this.tb_firstN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_firstN.Multiline = true;
            this.tb_firstN.Name = "tb_firstN";
            this.tb_firstN.Size = new System.Drawing.Size(276, 47);
            this.tb_firstN.TabIndex = 0;
            // 
            // tb_lastN
            // 
            this.tb_lastN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lastN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_lastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastN.Location = new System.Drawing.Point(203, 124);
            this.tb_lastN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_lastN.Multiline = true;
            this.tb_lastN.Name = "tb_lastN";
            this.tb_lastN.Size = new System.Drawing.Size(276, 47);
            this.tb_lastN.TabIndex = 1;
            // 
            // lb_first
            // 
            this.lb_first.AutoSize = true;
            this.lb_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_first.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_first.Location = new System.Drawing.Point(82, 41);
            this.lb_first.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_first.Name = "lb_first";
            this.lb_first.Size = new System.Drawing.Size(117, 24);
            this.lb_first.TabIndex = 2;
            this.lb_first.Text = "First Name:";
            this.lb_first.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_last
            // 
            this.lb_last.AutoSize = true;
            this.lb_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_last.Location = new System.Drawing.Point(85, 137);
            this.lb_last.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_last.Name = "lb_last";
            this.lb_last.Size = new System.Drawing.Size(114, 24);
            this.lb_last.TabIndex = 3;
            this.lb_last.Text = "Last Name:";
            this.lb_last.Click += new System.EventHandler(this.lb_last_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.White;
            this.lb_welcome.Location = new System.Drawing.Point(94, 225);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(32, 24);
            this.lb_welcome.TabIndex = 4;
            this.lb_welcome.Text = "\" \"";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_clear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Submit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 287);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 52);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(195, 2);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(189, 47);
            this.bt_clear.TabIndex = 1;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_Submit
            // 
            this.bt_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.Location = new System.Drawing.Point(2, 2);
            this.bt_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(189, 47);
            this.bt_Submit.TabIndex = 0;
            this.bt_Submit.Text = "Submit";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(628, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.lb_last);
            this.Controls.Add(this.lb_first);
            this.Controls.Add(this.tb_lastN);
            this.Controls.Add(this.tb_firstN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(512, 411);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_firstN;
        private System.Windows.Forms.TextBox tb_lastN;
        private System.Windows.Forms.Label lb_first;
        private System.Windows.Forms.Label lb_last;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_Submit;
    }
}


