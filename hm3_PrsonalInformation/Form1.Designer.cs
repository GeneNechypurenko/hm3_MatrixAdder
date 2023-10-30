namespace hm3_PrsonalInformation
{
    partial class PersonalInfo
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
            FirstNameTextBox = new TextBox();
            MidNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            MaleGenderPickRadioButton = new RadioButton();
            FemaleGenderPickRadioButton = new RadioButton();
            GenderPickGroupBox = new GroupBox();
            BirthDateTimePicker = new DateTimePicker();
            MaritalStatusComboBox = new ComboBox();
            AdditionalInfoTextBox = new TextBox();
            SaveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MainPanel = new Panel();
            GenderPickGroupBox.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(132, 32);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(251, 27);
            FirstNameTextBox.TabIndex = 0;
            // 
            // MidNameTextBox
            // 
            MidNameTextBox.Location = new Point(132, 98);
            MidNameTextBox.Name = "MidNameTextBox";
            MidNameTextBox.Size = new Size(251, 27);
            MidNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(132, 65);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(251, 27);
            LastNameTextBox.TabIndex = 2;
            // 
            // MaleGenderPickRadioButton
            // 
            MaleGenderPickRadioButton.AutoSize = true;
            MaleGenderPickRadioButton.Location = new Point(220, 26);
            MaleGenderPickRadioButton.Name = "MaleGenderPickRadioButton";
            MaleGenderPickRadioButton.Size = new Size(64, 24);
            MaleGenderPickRadioButton.TabIndex = 3;
            MaleGenderPickRadioButton.TabStop = true;
            MaleGenderPickRadioButton.Text = "Male";
            MaleGenderPickRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleGenderPickRadioButton
            // 
            FemaleGenderPickRadioButton.AutoSize = true;
            FemaleGenderPickRadioButton.Location = new Point(290, 26);
            FemaleGenderPickRadioButton.Name = "FemaleGenderPickRadioButton";
            FemaleGenderPickRadioButton.Size = new Size(80, 24);
            FemaleGenderPickRadioButton.TabIndex = 4;
            FemaleGenderPickRadioButton.TabStop = true;
            FemaleGenderPickRadioButton.Text = "Female";
            FemaleGenderPickRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenderPickGroupBox
            // 
            GenderPickGroupBox.Controls.Add(MaleGenderPickRadioButton);
            GenderPickGroupBox.Controls.Add(FemaleGenderPickRadioButton);
            GenderPickGroupBox.Location = new Point(7, 131);
            GenderPickGroupBox.Name = "GenderPickGroupBox";
            GenderPickGroupBox.Size = new Size(376, 62);
            GenderPickGroupBox.TabIndex = 5;
            GenderPickGroupBox.TabStop = false;
            GenderPickGroupBox.Text = "Gender:";
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(132, 199);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(251, 27);
            BirthDateTimePicker.TabIndex = 6;
            // 
            // MaritalStatusComboBox
            // 
            MaritalStatusComboBox.FormattingEnabled = true;
            MaritalStatusComboBox.Items.AddRange(new object[] { "Maried", "Single" });
            MaritalStatusComboBox.Location = new Point(132, 232);
            MaritalStatusComboBox.Name = "MaritalStatusComboBox";
            MaritalStatusComboBox.Size = new Size(251, 28);
            MaritalStatusComboBox.TabIndex = 7;
            // 
            // AdditionalInfoTextBox
            // 
            AdditionalInfoTextBox.Location = new Point(132, 266);
            AdditionalInfoTextBox.Multiline = true;
            AdditionalInfoTextBox.Name = "AdditionalInfoTextBox";
            AdditionalInfoTextBox.Size = new Size(251, 96);
            AdditionalInfoTextBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(154, 376);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 10;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 11;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 105);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 12;
            label3.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 240);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 13;
            label4.Text = "Marital Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 273);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 14;
            label5.Text = "Additional Info:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 206);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 15;
            label6.Text = "Birth Date:";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(FirstNameTextBox);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(MidNameTextBox);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(LastNameTextBox);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(GenderPickGroupBox);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(BirthDateTimePicker);
            MainPanel.Controls.Add(MaritalStatusComboBox);
            MainPanel.Controls.Add(SaveButton);
            MainPanel.Controls.Add(AdditionalInfoTextBox);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(397, 422);
            MainPanel.TabIndex = 16;
            // 
            // PersonalInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 422);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PersonalInfo";
            Text = "Personal Information";
            GenderPickGroupBox.ResumeLayout(false);
            GenderPickGroupBox.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FirstNameTextBox;
        private TextBox MidNameTextBox;
        private TextBox LastNameTextBox;
        private RadioButton MaleGenderPickRadioButton;
        private RadioButton FemaleGenderPickRadioButton;
        private GroupBox GenderPickGroupBox;
        private DateTimePicker BirthDateTimePicker;
        private ComboBox MaritalStatusComboBox;
        private TextBox AdditionalInfoTextBox;
        private Button SaveButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel MainPanel;
    }
}