namespace SimpleCalculator2
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
            this.lbl_operand1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_operand2 = new System.Windows.Forms.TextBox();
            this.txt_operator = new System.Windows.Forms.TextBox();
            this.txt_operand1 = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_operand1
            // 
            this.lbl_operand1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_operand1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operand1.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_operand1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_operand1.Location = new System.Drawing.Point(57, 121);
            this.lbl_operand1.Name = "lbl_operand1";
            this.lbl_operand1.Size = new System.Drawing.Size(169, 37);
            this.lbl_operand1.TabIndex = 0;
            this.lbl_operand1.Text = "Operand 1:";
            this.lbl_operand1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(57, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operator:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(57, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operand 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(57, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_result);
            this.panel1.Controls.Add(this.txt_operand2);
            this.panel1.Controls.Add(this.txt_operator);
            this.panel1.Controls.Add(this.txt_operand1);
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_operand1);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 498);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(63, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Simple Calculator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_result.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_result.Location = new System.Drawing.Point(232, 334);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(203, 35);
            this.txt_result.TabIndex = 9;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_operand2
            // 
            this.txt_operand2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_operand2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operand2.ForeColor = System.Drawing.Color.Cyan;
            this.txt_operand2.Location = new System.Drawing.Point(232, 269);
            this.txt_operand2.Name = "txt_operand2";
            this.txt_operand2.Size = new System.Drawing.Size(203, 35);
            this.txt_operand2.TabIndex = 8;
            this.txt_operand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_operator
            // 
            this.txt_operator.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_operator.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operator.ForeColor = System.Drawing.Color.Cyan;
            this.txt_operator.Location = new System.Drawing.Point(232, 199);
            this.txt_operator.Name = "txt_operator";
            this.txt_operator.Size = new System.Drawing.Size(203, 35);
            this.txt_operator.TabIndex = 7;
            this.txt_operator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_operand1
            // 
            this.txt_operand1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_operand1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operand1.ForeColor = System.Drawing.Color.Cyan;
            this.txt_operand1.Location = new System.Drawing.Point(232, 121);
            this.txt_operand1.Name = "txt_operand1";
            this.txt_operand1.Size = new System.Drawing.Size(203, 35);
            this.txt_operand1.TabIndex = 6;
            this.txt_operand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(51, 402);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(116, 40);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(194, 402);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 40);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(336, 402);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 40);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(489, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_operand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_operand1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_operand2;
        private System.Windows.Forms.TextBox txt_operator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
    }
}

