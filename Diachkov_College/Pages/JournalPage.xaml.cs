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
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : System.Windows.Controls.Page
    {
        public JournalPage()
        {
            InitializeComponent();
            JornalLv.ItemsSource = App.context.Journal.ToList();

            SpecialCmb.SelectedValuePath= "Id";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Spesial.ToList();

            DirectionCmb.SelectedValuePath = "Id";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            ActivityCmb.SelectedValuePath = "Id";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SpecialCmb.Text)&& string.IsNullOrEmpty(DirectionCmb.Text) && string.IsNullOrEmpty(GroupCmb.Text) && string.IsNullOrEmpty(ActivityCmb.Text)&& string.IsNullOrEmpty(MarkTb.Text))
            
            {
                MessageBox.Show("Заполните все поля!");
            }

            else
            {
                Journal journal = new Journal()
                {
                    DateEvent = (DateTime)DateEventDp
                }
            }
        }
    }
}
