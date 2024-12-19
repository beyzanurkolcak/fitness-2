using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fitnessuygulamasi
{
    public partial class Form1 : Form
    {
        public static string SelectedGoal { get; set; }
        public static string SelectedActivityLevel { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GoalComboBox.Items.Add("Zayıflama");
            GoalComboBox.Items.Add("Kilo Alma");
            GoalComboBox.Items.Add("Kas Yapma");

            ActivityLevelComboBox.Items.Add("Sedanter");
            ActivityLevelComboBox.Items.Add("Orta");
            ActivityLevelComboBox.Items.Add("Aktif");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GoalComboBox.SelectedItem == null || ActivityLevelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hedef ve hareket seviyesini seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) ||
                string.IsNullOrEmpty(HeightTextBox.Text) || string.IsNullOrEmpty(WeightTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=your_server_name;Database=FitnessDatabase;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Users (FirstName, LastName, Height, Weight, Goal, ActivityLevel) " +
                                         "VALUES (@FirstName, @LastName, @Height, @Weight, @Goal, @ActivityLevel)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        command.Parameters.AddWithValue("@Height", Convert.ToDecimal(HeightTextBox.Text));
                        command.Parameters.AddWithValue("@Weight", Convert.ToDecimal(WeightTextBox.Text));
                        command.Parameters.AddWithValue("@Goal", GoalComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@ActivityLevel", ActivityLevelComboBox.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (GoalComboBox.SelectedItem == null || ActivityLevelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hedef ve hareket seviyesini seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedGoal = GoalComboBox.SelectedItem.ToString();
            SelectedActivityLevel = ActivityLevelComboBox.SelectedItem.ToString();

            RaporForm raporForm = new RaporForm();
            raporForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}




    



