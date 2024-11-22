namespace chapter_9
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
            this.tb_firstNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_secondNum = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_error_firstNum = new System.Windows.Forms.Label();
            this.lb_error_secondNum = new System.Windows.Forms.Label();
            this.NUD_firstNum = new System.Windows.Forms.NumericUpDown();
            this.NUD_secondNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_firstNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_secondNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_firstNum
            // 
            this.tb_firstNum.BackColor = System.Drawing.Color.White;
            this.tb_firstNum.Location = new System.Drawing.Point(175, 76);
            this.tb_firstNum.Name = "tb_firstNum";
            this.tb_firstNum.Size = new System.Drawing.Size(147, 22);
            this.tb_firstNum.TabIndex = 0;
            this.tb_firstNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // tb_secondNum
            // 
            this.tb_secondNum.Location = new System.Drawing.Point(175, 138);
            this.tb_secondNum.Name = "tb_secondNum";
            this.tb_secondNum.Size = new System.Drawing.Size(147, 22);
            this.tb_secondNum.TabIndex = 3;
            this.tb_secondNum.Text = "0";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Black;
            this.bt_add.Location = new System.Drawing.Point(175, 201);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(62, 32);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.White;
            this.lb_result.Location = new System.Drawing.Point(86, 257);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(63, 20);
            this.lb_result.TabIndex = 5;
            this.lb_result.Text = "Result";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(175, 255);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(147, 22);
            this.tb_result.TabIndex = 6;
            // 
            // lb_error_firstNum
            // 
            this.lb_error_firstNum.AutoSize = true;
            this.lb_error_firstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_firstNum.ForeColor = System.Drawing.Color.Maroon;
            this.lb_error_firstNum.Location = new System.Drawing.Point(175, 54);
            this.lb_error_firstNum.Name = "lb_error_firstNum";
            this.lb_error_firstNum.Size = new System.Drawing.Size(0, 16);
            this.lb_error_firstNum.TabIndex = 7;
            // 
            // lb_error_secondNum
            // 
            this.lb_error_secondNum.AutoSize = true;
            this.lb_error_secondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_secondNum.ForeColor = System.Drawing.Color.Maroon;
            this.lb_error_secondNum.Location = new System.Drawing.Point(175, 119);
            this.lb_error_secondNum.Name = "lb_error_secondNum";
            this.lb_error_secondNum.Size = new System.Drawing.Size(0, 16);
            this.lb_error_secondNum.TabIndex = 8;
            // 
            // NUD_firstNum
            // 
            this.NUD_firstNum.Location = new System.Drawing.Point(342, 76);
            this.NUD_firstNum.Name = "NUD_firstNum";
            this.NUD_firstNum.Size = new System.Drawing.Size(120, 22);
            this.NUD_firstNum.TabIndex = 9;
            // 
            // NUD_secondNum
            // 
            this.NUD_secondNum.Location = new System.Drawing.Point(342, 136);
            this.NUD_secondNum.Name = "NUD_secondNum";
            this.NUD_secondNum.Size = new System.Drawing.Size(120, 22);
            this.NUD_secondNum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.NUD_secondNum);
            this.Controls.Add(this.NUD_firstNum);
            this.Controls.Add(this.lb_error_secondNum);
            this.Controls.Add(this.lb_error_firstNum);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_secondNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstNum);
            this.Name = "Form1";
            this.Text = "calculator";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_firstNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_secondNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_firstNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_secondNum;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lb_error_firstNum;
        private System.Windows.Forms.Label lb_error_secondNum;
        private System.Windows.Forms.NumericUpDown NUD_firstNum;
        private System.Windows.Forms.NumericUpDown NUD_secondNum;
    }
}


