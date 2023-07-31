using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class EmployeeInfoRepository
    {
        public ObservableCollection<Employee> EmployeesInfo1 { get; set; } = new ObservableCollection<Employee>
        {
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },

        };

        public ObservableCollection<Employee> EmployeesInfo2 { get; set; } = new ObservableCollection<Employee>
        {
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
            new Employee { IsChecked = true },
            new Employee { IsChecked = false },
            new Employee { IsChecked = false },
        };
    }
}
