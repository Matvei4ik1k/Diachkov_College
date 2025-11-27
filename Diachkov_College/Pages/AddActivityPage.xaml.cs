using Diachkov_College.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diachkov_College.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : System.Windows.Controls.Page
    {
        public AddActivityPage()
        {
            InitializeComponent();

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ActivitityTb.Text) && string.IsNullOrEmpty(DirectionCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Activity activity = new Activity()
                {
                    Name = ActivitityTb.Text,
                    Direction = DirectionCmb.SelectedItem as Direction
                };

                App.context.Activity.Add(activity);
                App.context.SaveChanges();
                MessageBox.Show("Активность добавлена");
                ActivitityTb.Text = "";
                DirectionCmb.Text = "";


            }
        }
    }
}
