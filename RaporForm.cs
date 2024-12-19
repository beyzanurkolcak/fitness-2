using System;
using System.Windows.Forms;

namespace fitnessuygulamasi
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Form1.SelectedGoal) || string.IsNullOrEmpty(Form1.SelectedActivityLevel))
            {
                ReportLabel.Text = "Hedef veya hareket seviyesi seçilmemiş.";
                return;
            }

            string goal = Form1.SelectedGoal;
            string activityLevel = Form1.SelectedActivityLevel;

            string exercisePlan = GenerateExercisePlan(goal, activityLevel);

            ReportLabel.Text = exercisePlan;
        }



        private string GenerateExercisePlan(string goal, string activityLevel)
        {
            if (goal == "Zayıflama" && activityLevel == "Aktif")
            {
                return "Haftada 4 gün kardiyo, 2 gün güç çalışması.";
            }
            else if (goal == "Kas Yapma" && activityLevel == "Orta")
            {
                return "Haftada 3 gün ağırsız egzersiz, 2 gün kardiyo.";
            }
            else if (goal == "Kilo Alma" && activityLevel == "Sedanter")
            {
                return "Haftada 3 gün düşük tempolu yürüyüş, 2 gün hafif egzersiz.";
            }
            else if (goal == "Zayıflama" && activityLevel == "Orta")
            {
                return "Haftada 3 gün kardiyo, 2 gün hafif güç çalışması.";
            }
            else if (goal == "Kas Yapma" && activityLevel == "Aktif")
            {
                return "Haftada 4 gün güç çalışması, 2 gün kardiyo.";
            }
            return "Önerilen egzersiz planı bulunamadı.";
        }
        
    }
}



   