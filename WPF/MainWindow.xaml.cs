using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
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
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;
using System.Data;
using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
this.sfDataGrid.GroupCollapsing += SfDataGrid_GroupCollapsing;
this.sfDataGrid.GroupExpanding += SfDataGrid_GroupExpanding;
this.sfDataGrid.SelectionChanging += SfDataGrid_SelectionChanging;
        }

        private void SfDataGrid_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            var visualcontainer = this.sfDataGrid.GetVisualContainer();
            var point = Mouse.GetPosition(visualcontainer);
            //Here you can get the row and column index based on the pointer position by using PointToCellRowColumnIndex() method 
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(point);
            //When the rowindex is zero , the row will be header row  
            if (!rowColumnIndex.IsEmpty)
            {
                if (rowColumnIndex.ColumnIndex == 0)
                    e.Cancel = true;
            }
        }

        private void SfDataGrid_GroupExpanding(object sender, GroupChangingEventArgs e)
        {
            var visualcontainer = this.sfDataGrid.GetVisualContainer();
            var point = Mouse.GetPosition(visualcontainer);
            //Here you can get the row and column index based on the pointer position by using PointToCellRowColumnIndex() method
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(point);
            //When the rowindex is zero , the row will be header row 
            if (!rowColumnIndex.IsEmpty)
            {               
                if (rowColumnIndex.ColumnIndex > 0)
                    e.Cancel = true;
            }
        }

        private void SfDataGrid_GroupCollapsing(object sender, GroupChangingEventArgs e)
        {
            var visualcontainer = this.sfDataGrid.GetVisualContainer();
            var point = Mouse.GetPosition(visualcontainer);
            //Here you can get the row and column index based on the pointer position by using PointToCellRowColumnIndex() method
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(point);
            //When the rowindex is zero , the row will be header row 
            if (!rowColumnIndex.IsEmpty)
            {
                if (rowColumnIndex.ColumnIndex > 0)
                    e.Cancel = true;
            }
        }
    }
}
         
   

