using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<DataClass> ob = new List<DataClass>();
            ob.Add(new DataClass() { col1 = "Row0Col1", col2 = "Row0Col2", col3 = "Row0Col3", col4 = "Row0Col4", col5 = "Row0Col5", col6 = "Row0Col6", col7 = "Row0Col7", col8 = "Row0Col8", col9 = "Row0Col9", col10 = "Row0Col10", col11 = "Row0Col11", col12 = "Row0Col12", col13 = "Row0Col13", col14 = "Row0Col14", col15 = "Row0Col15" });
            ob.Add(new DataClass() { col1 = "Row1Col1111111111111111111111111111111111111111111111111END", col2 = "Row1Col2222222222222222222222222222222222222End", col3 = "Row1Col333333333333333333333333333333333333333333333333333333333333333333333333333End", col4 = "Row1Col4", col5 = "Row1Col5", col6 = "Row1Col6", col7 = "Row1Col7", col8 = "Row1Col8", col9 = "Row1Col9", col10 = "Row1Col10", col11 = "Row1Col11", col12 = "Row1Col12", col13 = "Row1Col13", col14 = "Row1Col14", col15 = "Row1Col15" });
            ob.Add(new DataClass() { col1 = "Row2Col1", col2 = "Row2Col2", col3 = "Row2Col3", col4 = "Row2Col4", col5 = "Row2Col5", col6 = "Row2Col6", col7 = "Row2Col7", col8 = "Row2Col8", col9 = "Row2Col9", col10 = "Row2Col10", col11 = "Row2Col11", col12 = "Row2Col12", col13 = "Row2Col13", col14 = "Row2Col14", col15 = "Row2Col15" });
            ob.Add(new DataClass() { col1 = "Row3Col1", col2 = "Row3Col2", col3 = "Row3Col3", col4 = "Row3Col4", col5 = "Row3Col5", col6 = "Row3Col6", col7 = "Row3Col7", col8 = "Row3Col8", col9 = "Row3Col9", col10 = "Row3Col10", col11 = "Row3Col11", col12 = "Row3Col12", col13 = "Row3Col13", col14 = "Row3Col14", col15 = "Row3Col15" });
            myDataGrid.ItemsSource = ob;
        }

        private void chkAllColumns_Checked(object sender, RoutedEventArgs e)
        {
            if (((bool)((CheckBox)sender).IsChecked))
            {
                for (int i = 4; i < myDataGrid.Columns.Count; i++)
                    myDataGrid.Columns[i].Visibility = Visibility.Visible;
                for (int i = 0; i < myDataGrid.Columns.Count; i++)
                    if ((bool)adjust.IsChecked)
                        myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                    else
                        myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);

            }
            else
            {
                for (int i = 4; i < myDataGrid.Columns.Count; i++)
                    myDataGrid.Columns[i].Visibility = Visibility.Collapsed;
                for (int i = 0; i < myDataGrid.Columns.Count; i++)
                    if ((bool)adjust.IsChecked)
                        myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                    else
                        myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
            }
        }

        private void adjust_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < myDataGrid.Columns.Count; i++)
                if (((RadioButton)sender).Content.Equals("Set column width to star"))
                    myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                else
                    myDataGrid.Columns[i].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
        }
    }
    class DataClass
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
        public string col6 { get; set; }
        public string col7 { get; set; }
        public string col8 { get; set; }
        public string col9 { get; set; }
        public string col10 { get; set; }
        public string col11 { get; set; }
        public string col12 { get; set; }
        public string col13 { get; set; }
        public string col14 { get; set; }
        public string col15 { get; set; }
    }
}
