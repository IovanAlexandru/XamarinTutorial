using System;
using System.Linq;
using Xamarin.Forms;

namespace HelloWorld.LabelExample
{
    public class CountedLabel : Label
    {
        public int WordCount
        {
            private set { SetValue(WordCountKey, value); }
            get => (int) GetValue(WordCountProperty);
        }

        private static readonly BindablePropertyKey WordCountKey = BindableProperty.CreateReadOnly("WordCount", typeof(int), typeof(CountedLabel), 0);
        public static readonly BindableProperty WordCountProperty = WordCountKey.BindableProperty;

        public CountedLabel()
        {
            this.PropertyChanged += CountedLabel_PropertyChanged;
        }

        private void CountedLabel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Text))
            {
                WordCount = string.IsNullOrEmpty(Text) ? 
                    0 : 
                    Text.Split(new[] {' ', '-', '\u2014'}, StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }
    }
}
