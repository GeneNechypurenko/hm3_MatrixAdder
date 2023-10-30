namespace hm3_MatrixAdder
{
    public partial class SelectMatrixSizeForm : Form
    {
        public SelectMatrixSizeForm()
        {
            InitializeComponent();

            MatrixSize3RadioButton.Checked = true;
        }

        private void SelectMatrixSizeButton_Click(object sender, EventArgs e)
        {
            int matrixSize = int
                .Parse(SelectSizeGroupBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(el => el.Checked).Tag.ToString());

            switch (matrixSize)
            {
                case 3:
                    Size3MatrixInput size3MatrixInputForm = new Size3MatrixInput();
                    size3MatrixInputForm.Show();
                    this.Hide();
                    break;

                case 6:
                    Size6MatrixInput size6MatrixInput = new Size6MatrixInput();
                    size6MatrixInput.Show();
                    this.Hide();
                    break;

                case 9:
                    Size9MatrixInput size9MatrixInput = new Size9MatrixInput();
                    size9MatrixInput.Show();
                    this.Hide();
                    break;
            }
        }
    }
}