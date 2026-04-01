namespace BMI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bmiValueLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高(公分)";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重(公斤)";
            
            // heightTextBox
            this.heightTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.heightTextBox.Location = new System.Drawing.Point(130, 27);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(150, 29);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            
            // weightTextBox
            this.weightTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.weightTextBox.Location = new System.Drawing.Point(130, 77);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(150, 29);
            this.weightTextBox.TabIndex = 3;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            
            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "BMI 值：";
            
            // bmiValueLabel
            this.bmiValueLabel.AutoSize = true;
            this.bmiValueLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.bmiValueLabel.Location = new System.Drawing.Point(130, 130);
            this.bmiValueLabel.Name = "bmiValueLabel";
            this.bmiValueLabel.Size = new System.Drawing.Size(30, 21);
            this.bmiValueLabel.TabIndex = 5;
            this.bmiValueLabel.Text = "0.0";
            
            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "體型分類：";
            
            // categoryLabel
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.categoryLabel.ForeColor = System.Drawing.Color.Green;
            this.categoryLabel.Location = new System.Drawing.Point(130, 180);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 21);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "正常範圍";
            
            // resetButton
            this.resetButton.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.resetButton.Location = new System.Drawing.Point(130, 220);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 35);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "重置為預設值";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            
            // groupBox1
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.groupBox1.Location = new System.Drawing.Point(310, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI 計算公式與分類標準";
            
            // label5
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label5.Location = new System.Drawing.Point(315, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 210);
            this.label5.TabIndex = 10;
            this.label5.Text = "BMI 計算公式：\r\nBMI = 體重(公斤) / 身高²(公尺²)\r\n\r\nBMI 分類標準：\r\n  體重過低(輕度): BMI < 16.5\r\n  體重過低(中度): 16.5 ≤ BMI < 18.5\r\n  正常範圍: 18.5 ≤ BMI < 25\r\n  體重過重(輕度): 25 ≤ BMI < 27\r\n  體重過重(中度): 27 ≤ BMI < 30\r\n  肥胖(輕度): 30 ≤ BMI < 35\r\n  肥胖(中度): 35 ≤ BMI < 40\r\n  肥胖(重度): BMI ≥ 40";
            
            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(30, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "備註：灰底欄位為預設值(男性平均身高170公分、體重70公斤)\r\n請輸入有效數值以計算 BMI";
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bmiValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "BMI 計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bmiValueLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

