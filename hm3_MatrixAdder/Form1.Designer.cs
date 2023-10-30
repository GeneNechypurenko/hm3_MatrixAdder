namespace hm3_MatrixAdder
{
    partial class SelectMatrixSizeForm
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
            SelectSizeGroupBox = new GroupBox();
            MatrixSize9RadioButton = new RadioButton();
            MatrixSize6RadioButton = new RadioButton();
            MatrixSize3RadioButton = new RadioButton();
            SelectMatrixSizeButton = new Button();
            SelectSizeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectSizeGroupBox
            // 
            SelectSizeGroupBox.Controls.Add(MatrixSize9RadioButton);
            SelectSizeGroupBox.Controls.Add(MatrixSize6RadioButton);
            SelectSizeGroupBox.Controls.Add(MatrixSize3RadioButton);
            SelectSizeGroupBox.Location = new Point(12, 12);
            SelectSizeGroupBox.Name = "SelectSizeGroupBox";
            SelectSizeGroupBox.Size = new Size(245, 125);
            SelectSizeGroupBox.TabIndex = 0;
            SelectSizeGroupBox.TabStop = false;
            SelectSizeGroupBox.Text = "Select Size";
            // 
            // MatrixSize9RadioButton
            // 
            MatrixSize9RadioButton.AutoSize = true;
            MatrixSize9RadioButton.Location = new Point(6, 86);
            MatrixSize9RadioButton.Name = "MatrixSize9RadioButton";
            MatrixSize9RadioButton.Size = new Size(56, 24);
            MatrixSize9RadioButton.TabIndex = 2;
            MatrixSize9RadioButton.TabStop = true;
            MatrixSize9RadioButton.Tag = "9";
            MatrixSize9RadioButton.Text = "9x9";
            MatrixSize9RadioButton.UseVisualStyleBackColor = true;
            // 
            // MatrixSize6RadioButton
            // 
            MatrixSize6RadioButton.AutoSize = true;
            MatrixSize6RadioButton.Location = new Point(6, 56);
            MatrixSize6RadioButton.Name = "MatrixSize6RadioButton";
            MatrixSize6RadioButton.Size = new Size(56, 24);
            MatrixSize6RadioButton.TabIndex = 1;
            MatrixSize6RadioButton.TabStop = true;
            MatrixSize6RadioButton.Tag = "6";
            MatrixSize6RadioButton.Text = "6x6";
            MatrixSize6RadioButton.UseVisualStyleBackColor = true;
            // 
            // MatrixSize3RadioButton
            // 
            MatrixSize3RadioButton.AutoSize = true;
            MatrixSize3RadioButton.Location = new Point(6, 26);
            MatrixSize3RadioButton.Name = "MatrixSize3RadioButton";
            MatrixSize3RadioButton.Size = new Size(56, 24);
            MatrixSize3RadioButton.TabIndex = 0;
            MatrixSize3RadioButton.TabStop = true;
            MatrixSize3RadioButton.Tag = "3";
            MatrixSize3RadioButton.Text = "3x3";
            MatrixSize3RadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectMatrixSizeButton
            // 
            SelectMatrixSizeButton.Location = new Point(86, 154);
            SelectMatrixSizeButton.Name = "SelectMatrixSizeButton";
            SelectMatrixSizeButton.Size = new Size(94, 42);
            SelectMatrixSizeButton.TabIndex = 1;
            SelectMatrixSizeButton.Text = "Select";
            SelectMatrixSizeButton.UseVisualStyleBackColor = true;
            SelectMatrixSizeButton.Click += SelectMatrixSizeButton_Click;
            // 
            // SelectMatrixSizeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 208);
            Controls.Add(SelectMatrixSizeButton);
            Controls.Add(SelectSizeGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectMatrixSizeForm";
            Text = "Select Matrix Size";
            SelectSizeGroupBox.ResumeLayout(false);
            SelectSizeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectSizeGroupBox;
        private RadioButton MatrixSize9RadioButton;
        private RadioButton MatrixSize6RadioButton;
        private RadioButton MatrixSize3RadioButton;
        private Button SelectMatrixSizeButton;
    }
}