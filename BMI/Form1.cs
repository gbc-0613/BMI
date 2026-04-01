using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        private bool isInitialized = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isInitialized = false;
            // Set default values (male average: 170cm, 70kg)
            heightTextBox.Text = "170";
            weightTextBox.Text = "70";
            heightTextBox.BackColor = Color.LightGray;
            weightTextBox.BackColor = Color.LightGray;
            isInitialized = true;
            // Calculate BMI after initialization
            CalculateBMI();
        }

        private void CalculateBMI()
        {
            // Skip calculation during initialization
            if (!isInitialized)
                return;

            try
            {
                // Skip calculation if either input is empty
                if (string.IsNullOrWhiteSpace(heightTextBox.Text) || string.IsNullOrWhiteSpace(weightTextBox.Text))
                {
                    return;
                }

                // Get input values
                if (!double.TryParse(heightTextBox.Text, out double height) || height <= 0 || height > 300)
                {
                    MessageBox.Show("身高輸入無效，請輸入介於1-300公分的數值", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(weightTextBox.Text, out double weight) || weight <= 0 || weight > 500)
                {
                    MessageBox.Show("體重輸入無效，請輸入介於1-500公斤的數值", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert height from cm to m
                double heightInMeters = height / 100.0;

                // Calculate BMI
                double bmi = weight / (heightInMeters * heightInMeters);

                // Display BMI value
                bmiValueLabel.Text = bmi.ToString("F1");

                // Determine BMI category
                string category = GetBMICategory(bmi);
                categoryLabel.Text = category;

                // Set category label color based on BMI
                SetCategoryColor(bmi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message, "計算錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 16.5)
                return "體重過低(輕度)";
            else if (bmi < 18.5)
                return "體重過低(中度)";
            else if (bmi < 25)
                return "正常範圍";
            else if (bmi < 27)
                return "體重過重(輕度)";
            else if (bmi < 30)
                return "體重過重(中度)";
            else if (bmi < 35)
                return "肥胖(輕度)";
            else if (bmi < 40)
                return "肥胖(中度)";
            else
                return "肥胖(重度)";
        }

        private void SetCategoryColor(double bmi)
        {
            if (bmi < 16.5)
                categoryLabel.ForeColor = Color.DarkBlue;
            else if (bmi < 18.5)
                categoryLabel.ForeColor = Color.Blue;
            else if (bmi < 25)
                categoryLabel.ForeColor = Color.Green;
            else if (bmi < 27)
                categoryLabel.ForeColor = Color.Gold;
            else if (bmi < 30)
                categoryLabel.ForeColor = Color.Orange;
            else if (bmi < 35)
                categoryLabel.ForeColor = Color.OrangeRed;
            else if (bmi < 40)
                categoryLabel.ForeColor = Color.Red;
            else
                categoryLabel.ForeColor = Color.DarkRed;
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Remove gray background when user starts typing
            if (heightTextBox.BackColor == Color.LightGray && heightTextBox.Text.Length > 0)
            {
                heightTextBox.BackColor = Color.White;
            }
            CalculateBMI();
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Remove gray background when user starts typing
            if (weightTextBox.BackColor == Color.LightGray && weightTextBox.Text.Length > 0)
            {
                weightTextBox.BackColor = Color.White;
            }
            CalculateBMI();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            heightTextBox.Text = "170";
            weightTextBox.Text = "70";
            heightTextBox.BackColor = Color.LightGray;
            weightTextBox.BackColor = Color.LightGray;
            // Recalculate BMI with default values
            CalculateBMI();
        }
    }
}
