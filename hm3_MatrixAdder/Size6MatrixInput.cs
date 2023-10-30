using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hm3_MatrixAdder
{
    public partial class Size6MatrixInput : Form
    {
        const int size = 6;
        int[,] firstMatrix = new int[size, size];
        int[,] secondMatrix = new int[size, size];
        int[,] resultMatrix = new int[size, size];
        public Size6MatrixInput()
        {
            InitializeComponent();

            foreach (TextBox el in FirstMatrixLayoutPanel.Controls.OfType<TextBox>())
            {
                el.MaxLength = 1;
                el.KeyPress += El_KeyPress;
            }

            foreach (TextBox el in SecondMatrixLayoutPanel.Controls.OfType<TextBox>())
            {
                el.MaxLength = 1;
                el.KeyPress += El_KeyPress;
            }

            foreach (TextBox el in ResultingMatrixLayoutPanel.Controls.OfType<TextBox>())
            {
                el.MaxLength = 2;
                el.ReadOnly = true;
            }
        }

        private void El_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            int index = 0;

            MatrixParse(firstMatrix, FirstMatrixLayoutPanel, index);
            MatrixParse(secondMatrix, SecondMatrixLayoutPanel, index);
            MatrixAddition(resultMatrix, firstMatrix, secondMatrix);

            foreach (TextBox el in ResultingMatrixLayoutPanel.Controls.OfType<TextBox>())
            {
                el.Text = resultMatrix[index / size, index % size].ToString();
                ++index;
            }
        }

        private void MatrixAddition(int[,] resultMatrix, int[,] firstMatrix, int[,] secondMatrix)
        {
            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    resultMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                }
            }
        }

        private void MatrixParse(int[,] matrix, FlowLayoutPanel matrixLayoutPanel, int index)
        {
            foreach (TextBox el in matrixLayoutPanel.Controls.OfType<TextBox>())
            {
                if (el.Text != string.Empty)
                {
                    matrix[index / size, index % size] = int.Parse(el.Text);
                }
                else
                {
                    matrix[index / size, index % size] = 0;
                }
                ++index;
            }
        }
    }
}
