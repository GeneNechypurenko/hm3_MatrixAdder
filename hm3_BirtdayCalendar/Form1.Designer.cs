namespace hm3_BirtdayCalendar
{
    partial class BirtdayCalendarForm
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
            InputDateGroupBox = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            InputYearTextBox = new TextBox();
            InputMonthTextBox = new TextBox();
            InputDayTextBox = new TextBox();
            MonthCalendar = new MonthCalendar();
            ShowBirtDayButton = new Button();
            InputDateGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InputDateGroupBox
            // 
            InputDateGroupBox.Controls.Add(label3);
            InputDateGroupBox.Controls.Add(label2);
            InputDateGroupBox.Controls.Add(label1);
            InputDateGroupBox.Controls.Add(InputYearTextBox);
            InputDateGroupBox.Controls.Add(InputMonthTextBox);
            InputDateGroupBox.Controls.Add(InputDayTextBox);
            InputDateGroupBox.Location = new Point(12, 28);
            InputDateGroupBox.Name = "InputDateGroupBox";
            InputDateGroupBox.Size = new Size(172, 130);
            InputDateGroupBox.TabIndex = 0;
            InputDateGroupBox.TabStop = false;
            InputDateGroupBox.Text = "Enter Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 59);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "yyyy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "mm -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 3;
            label1.Text = "dd -";
            // 
            // InputYearTextBox
            // 
            InputYearTextBox.Location = new Point(85, 82);
            InputYearTextBox.MaxLength = 4;
            InputYearTextBox.Name = "InputYearTextBox";
            InputYearTextBox.Size = new Size(54, 27);
            InputYearTextBox.TabIndex = 2;
            // 
            // InputMonthTextBox
            // 
            InputMonthTextBox.Location = new Point(52, 82);
            InputMonthTextBox.MaxLength = 2;
            InputMonthTextBox.Name = "InputMonthTextBox";
            InputMonthTextBox.Size = new Size(27, 27);
            InputMonthTextBox.TabIndex = 1;
            // 
            // InputDayTextBox
            // 
            InputDayTextBox.Location = new Point(19, 82);
            InputDayTextBox.MaxLength = 2;
            InputDayTextBox.Name = "InputDayTextBox";
            InputDayTextBox.Size = new Size(27, 27);
            InputDayTextBox.TabIndex = 0;
            // 
            // MonthCalendar
            // 
            MonthCalendar.Location = new Point(196, 28);
            MonthCalendar.Name = "MonthCalendar";
            MonthCalendar.TabIndex = 1;
            // 
            // ShowBirtDayButton
            // 
            ShowBirtDayButton.Location = new Point(31, 192);
            ShowBirtDayButton.Name = "ShowBirtDayButton";
            ShowBirtDayButton.Size = new Size(120, 29);
            ShowBirtDayButton.TabIndex = 2;
            ShowBirtDayButton.Text = "Show Birthday";
            ShowBirtDayButton.UseVisualStyleBackColor = true;
            ShowBirtDayButton.Click += ShowBirtDayButton_Click;
            // 
            // BirtdayCalendarForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 248);
            Controls.Add(ShowBirtDayButton);
            Controls.Add(MonthCalendar);
            Controls.Add(InputDateGroupBox);
            Name = "BirtdayCalendarForm";
            Text = "Birthday Calendar";
            InputDateGroupBox.ResumeLayout(false);
            InputDateGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InputDateGroupBox;
        private TextBox InputYearTextBox;
        private TextBox InputMonthTextBox;
        private TextBox InputDayTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private MonthCalendar MonthCalendar;
        private Button ShowBirtDayButton;
    }
}