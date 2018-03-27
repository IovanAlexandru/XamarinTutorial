using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCustomCellDemoPage : ContentPage
    {
        public ListViewCustomCellDemoPage()
        {
            InitializeComponent();
            list.ItemsSource = NamedColor.All.Select((item, index) => new
            {
                Index = index,
                NamedColor = item
            }).GroupBy(item => new
            {
                Group = item.Index % 10
            }).Select(gr => new NamedColorGroup($"G {gr.Key.Group}", gr.Select(item => item.NamedColor).ToList()))
            .ToList();
        }
    }
}