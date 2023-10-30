using System.Text.RegularExpressions;

namespace hm3_PrsonalInformation
{
    public partial class PersonalInfo : Form
    {
        string fileName = "data.txt";
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string middleName = MidNameTextBox.Text;
            string gender = MaleGenderPickRadioButton.Checked ? "Male" : "Female";
            DateTime birthDate = BirthDateTimePicker.Value;
            string maritalStatus = MaritalStatusComboBox.SelectedItem.ToString();
            string additionalInfo = AdditionalInfoTextBox.Text;

            if (!IsValidName(lastName) || !IsValidName(firstName) || !IsValidName(middleName))
            {
                MessageBox.Show("Must contain only literals and can't be empty.");
                return;
            }

            string dataToSave = $"Last name: {lastName}\n" +
                                $"First name: {firstName}\n" +
                                $"Middle name: {middleName}\n" +
                                $"Gender: {gender}\n" +
                                $"Birht date: {birthDate:dd.MM.yyyy}\n" +
                                $"Marital status: {maritalStatus}\n" +
                                $"Additional info: {additionalInfo}";

            try
            {
                File.WriteAllText(fileName, dataToSave);

                MessageBox.Show($"Data successfully saved to file {fileName}.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving to a file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-Zà-ÿÀ-ß\s]+$";
            return !string.IsNullOrEmpty(name) && Regex.IsMatch(name, pattern);
        }
    }
}