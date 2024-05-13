using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ViewResults : UserControl
    {
        public ViewResults()
        {
            InitializeComponent();
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Surveys";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                var reader = command.ExecuteReader();
                int counter_rows = 0;
                int counter_pizza = 0;
                int counter_pasta = 0;
                int counter_pap_worse = 0;
                int counter_other = 0;
                int counter_age = 0;
                int counter_movies = 0;
                int counter_watch_tv = 0;
                int counter_listen_radio = 0;
                int counter_eat_out = 0;

                List<int> age = new List<int>();

                while (reader.Read())
                {
                    counter_rows++;
                    string _dob = reader.GetString(2);
                    DateTime dob = DateTime.ParseExact(_dob, "yyyy/MM/dd", null);
                    int _age = CalculateAge(dob);

                    // Calculate age
                    counter_age += _age;
                    age.Add(_age);
                    if (reader["fav_food"].ToString() == "Pasta")
                    {
                        counter_pasta++;
                    }
                    else if (reader["fav_food"].ToString() == "Pizza")
                    {
                        counter_pizza++;
                    }
                    else if (reader["fav_food"].ToString() == "Pap and Wors")
                    {
                        counter_pap_worse++;
                    }
                    else
                    {
                        counter_other++;
                    }
                    if (reader["watch_movies"].ToString() == "Normal" || reader["watch_movies"].ToString() == "Agree" || reader["watch_movies"].ToString() == "Strongly Agree")
                    {
                        counter_movies++;
                    }
                    if (reader["listen_radio"].ToString() == "Normal" || reader["listen_radio"].ToString() == "Agree" || reader["listen_radio"].ToString() == "Strongly Agree")
                    {
                        counter_listen_radio++;
                    }
                    if (reader["watch_tv"].ToString() == "Normal" || reader["watch_tv"].ToString() == "Agree" || reader["watch_tv"].ToString() == "Strongly Agree")
                    {
                        counter_watch_tv++;
                    }
                    if (reader["eat_out"].ToString() == "Normal" || reader["eat_out"].ToString() == "Agree" || reader["eat_out"].ToString() == "Strongly Agree")
                    {
                        counter_eat_out++;
                    }
                    //watch_movies
                    //                    listen_radio
                    //                    eat_out
                    //watch_tv


                }
                lblTotalSurvey.Text = counter_rows.ToString();
                lblAgeAverage.Text = $"{counter_age / counter_rows}";
                int oldest;
                int youngest;

                FindHighestAndSmallest(age, out oldest, out youngest);

                lblTotalYoungest.Text = youngest.ToString();
                lblTotalOldest.Text = oldest.ToString();

                double tot_wors = counter_pap_worse / counter_rows * 100;
                double tot_piza = counter_pizza / counter_rows * 100;
                double tot_pasta = counter_pasta / counter_rows * 100;
                lblPercentagePapWors.Text = $"{(int)tot_wors}%";
                lblPercentagePizza.Text = $"{(int)tot_piza}%";
                lblPercentagePasta.Text = $"{(int)tot_pasta}%";



                lblWatchTv.Text = $"{counter_watch_tv}";
                lblEatOut.Text = $"{counter_eat_out}";
                lblMovies.Text = $"{counter_movies}";
                lblRadio.Text = $"{counter_listen_radio}";
            }

        }
        static int CalculateAge(DateTime dob)
        {
            // Get the current date
            DateTime now = DateTime.Today;

            // Calculate the age
            int age = now.Year - dob.Year;

            // Subtract a year if the birthday hasn't occurred yet this year
            if (now < dob.AddYears(age))
            {
                age--;
            }

            return age;
        }
        static void FindHighestAndSmallest(List<int> age, out int highest, out int smallest)
        {
            // Check if the list is empty
            if (age.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            // Initialize the highest and smallest values to the first element of the list
            highest = age[0];
            smallest = age[0];

            // Iterate through the list starting from the second element
            foreach (int number in age)
            {
                // Update the highest value if the current number is higher
                if (number > highest)
                {
                    highest = number;
                }

                // Update the smallest value if the current number is smaller
                if (number < smallest)
                {
                    smallest = number;
                }
            }
        }
    }
}
