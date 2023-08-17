
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<WeakReference> references = new List<WeakReference>();
 

        public MainPage()
        {
            InitializeComponent();

            listView.ItemTemplate = new DataTemplate(() =>
            {
                var cell = new ViewCell { View = new Label() };
                references.Add(new(cell.View));
                return cell;
            });
        }

        void Log()
        {
            Debug.WriteLine($"CheckBox's alive: {references.Count(l => l.IsAlive)}");
        }

        private void ItemSource_One_Button_Clicked(object sender, EventArgs e)
        {
			GC.Collect();
			Log();
            listView.ItemsSource = employeeInfoRepository.EmployeesInfo1;
            
        }

        private void ItemSource_Two_Button_Clicked(object sender, EventArgs e)
        {
			GC.Collect();
			Log();
			listView.ItemsSource = employeeInfoRepository.EmployeesInfo2;
        }
    }
}
