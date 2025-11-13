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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : System.Windows.Controls.Page
    {
        public AddGroupPage()
        {
            InitializeComponent();

            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Spesial.ToList();
        }



        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GroupTb.Text) && string.IsNullOrEmpty(SpecialCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Group group = new Group()
                {
                    Name = GroupTb.Text,
                    Spesial = SpecialCmb.SelectedItem as Spesial
                };

                App.context.Group.Add(group);
                App.context.SaveChanges();
                MessageBox.Show("Группа добавлена");
                GroupTb.Text = "";
                SpecialCmb.Text = "";


            }
        }
    }
}
