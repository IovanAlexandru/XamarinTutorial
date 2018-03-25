using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerDemoPage : ContentPage
    {
        public PickerDemoPage()
        {
            InitializeComponent();
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (entry == null)
                return;

            Picker picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == -1)
                return;

            string selectedItem = picker.Items[selectedIndex];
            PropertyInfo propertyInfo = typeof(Keyboard).GetRuntimeProperty(selectedItem);
            entry.Keyboard = (Keyboard) propertyInfo.GetValue(null);
        }
    }
}