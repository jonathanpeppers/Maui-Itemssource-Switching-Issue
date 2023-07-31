
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
 

        public MainPage()
        {
            InitializeComponent();

        }

        private void ItemSource_One_Button_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = employeeInfoRepository.EmployeesInfo1;
            
        }

        private void ItemSource_Two_Button_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = employeeInfoRepository.EmployeesInfo2;
        }
    }
}
