using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.UserControls
{
    public partial class NewSurvey : UserControl
    {
        public NewSurvey()
        {
            InitializeComponent();
        }
        private string watch_movies;
        private string listen_radio;
        private string eat_out;
        private string watch_tv;
        private string fav_food; 
        
        private void CheckRadios()
        {
            if (radioEetOutAgree.Checked)
            {
                eat_out = "Agree";
            }
            if (radioEetOutDisagree.Checked)
            {
                eat_out = "Disagree";
            }
            if (radioEetOutStronglyAgree.Checked)
            {
                eat_out = "Strongly Agree";
            }
            if (radioEetOutStronglyDisagree.Checked)
            {
                eat_out = "Strongly Disagree";
            }
            if (radioEetOutNormal.Checked)
            {
                eat_out = "Normal";
            }
            //.........movies
            if (radioMoviesAgree.Checked)
            {
                watch_movies = "Agree";
            }if (radioMoviesStronglyDisagree.Checked)
            {
                watch_movies = "Strongly Disagree";
            }if (radioMoviesNormal.Checked)
            {
                watch_movies = "Normal";
            }if (radioMoviesDisagree.Checked)
            {
                watch_movies = "Disagree";
            }if (radioMoviesStonglyAgree.Checked)
            {
                watch_movies = "Strongly Agree";
            }
            //..radio
            if (radioListenRadioAgree.Checked)
            {
                listen_radio = "Agree";
            }if (radioListenRadioStronglyAgree.Checked)
            {
                listen_radio = "Strongly Agree";
            }if (radioListenRadioNormal.Checked)
            {
                listen_radio = "Normal";
            }if (radioListenRadioDisagree.Checked)
            {
                listen_radio = "Disagree";
            }if (radioListenRadioStronglyDisagree.Checked)
            {
                listen_radio = "Strongly Disagree";
            }

            //
            if (radioWatchTvAgree.Checked){
                watch_tv= "Agree";
            }if (radioWatchTvStronglyAgree.Checked){
                watch_tv= "Strongly Agree";
            }if (radioWatchTvDisagree.Checked){
                watch_tv= "Disagree";
            }if (radioWatchTvStronglyDisagree.Checked){
                watch_tv = "Strongly Disagree";
            }
            if (radioWatchTvNormal.Checked){
                watch_tv= "Normal"; 
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            CheckRadios();
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Assuming you have a MySqlConnection named "connection"
            string query = "INSERT INTO surveys (fullnames, dob, email, contact, fav_food, watch_movies, listen_radio, eat_out, watch_tv) " +
                           "VALUES (@fullnames, @dob, @email, @contact, @fav_food, @watch_movies, @listen_radio, @eat_out, @watch_tv)";
            if (!string.IsNullOrEmpty(InputName.Text) &&
                !string.IsNullOrEmpty(InputDOB.Text) &&
                !string.IsNullOrEmpty(InputEmail.Text) &&
                !string.IsNullOrEmpty(InputContactNumber.Text) &&
                !string.IsNullOrEmpty(fav_food) &&
                !string.IsNullOrEmpty(watch_movies) &&
                !string.IsNullOrEmpty(listen_radio) &&
                !string.IsNullOrEmpty(eat_out) &&
                !string.IsNullOrEmpty(watch_tv))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullnames", InputName.Text);
                    command.Parameters.AddWithValue("@dob", InputDOB.Text);
                    command.Parameters.AddWithValue("@email", InputEmail.Text);
                    command.Parameters.AddWithValue("@contact", InputContactNumber.Text);
                    command.Parameters.AddWithValue("@fav_food", fav_food);
                    command.Parameters.AddWithValue("@watch_movies", watch_movies);
                    command.Parameters.AddWithValue("@listen_radio", listen_radio);
                    command.Parameters.AddWithValue("@eat_out", eat_out);
                    command.Parameters.AddWithValue("@watch_tv", watch_tv);

                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void CheckPizza_CheckedChanged(object sender, EventArgs e)
        {
            fav_food = CheckPizza.Text;
        }

        private void CheckPasta_CheckedChanged(object sender, EventArgs e)
        {
            fav_food = CheckPasta.Text;
        }

        private void CheckPap_CheckedChanged(object sender, EventArgs e)
        {
            fav_food = CheckPasta.Text.Trim();
        }

        private void CheckOther_CheckedChanged(object sender, EventArgs e)
        {
            fav_food = CheckOther.Text.Trim();
        }
    }
}
