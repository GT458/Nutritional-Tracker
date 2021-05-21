namespace NewWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitDataButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.ActivityUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // submitDataButton
            // 
            this.submitDataButton.Location = new System.Drawing.Point(12, 395);
            this.submitDataButton.Name = "submitDataButton";
            this.submitDataButton.Size = new System.Drawing.Size(101, 23);
            this.submitDataButton.TabIndex = 0;
            this.submitDataButton.Text = "Submit Data";
            this.submitDataButton.UseVisualStyleBackColor = true;
            this.submitDataButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight (lbs)";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Height (Inches)";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Activity [0 = Sedentary, 1 = Lightly Active, 2 = Moderately Active, 3 = Very Acti" +
    "ve]";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(12, 260);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 19);
            this.maleRadioButton.TabIndex = 3;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(12, 285);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(63, 19);
            this.femaleRadioButton.TabIndex = 3;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(12, 197);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(120, 23);
            this.heightUpDown.TabIndex = 4;
            // 
            // weightUpDown
            // 
            this.weightUpDown.Location = new System.Drawing.Point(12, 138);
            this.weightUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown.Name = "weightUpDown";
            this.weightUpDown.Size = new System.Drawing.Size(120, 23);
            this.weightUpDown.TabIndex = 5;
            this.weightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(12, 80);
            this.ageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(120, 23);
            this.ageUpDown.TabIndex = 5;
            this.ageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageUpDown.ValueChanged += new System.EventHandler(this.ageUpDown_ValueChanged);
            // 
            // ActivityUpDown
            // 
            this.ActivityUpDown.Location = new System.Drawing.Point(12, 340);
            this.ActivityUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ActivityUpDown.Name = "ActivityUpDown";
            this.ActivityUpDown.Size = new System.Drawing.Size(120, 23);
            this.ActivityUpDown.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Current Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActivityUpDown);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.weightUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.submitDataButton);
            this.Name = "Form1";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitDataButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown weightUpDown;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.NumericUpDown ActivityUpDown;
        private System.Windows.Forms.Button button1;
    }
}

