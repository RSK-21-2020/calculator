using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Calculator;

namespace GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public void onCalculateButtonClicked(object? sender, RoutedEventArgs routedEventArgs)
        {
            var inputNum1 = this.FindControl<TextBox>("input_num1");
            var inputNum2 = this.FindControl<TextBox>("input_num2");
            var outputNum = this.FindControl<TextBox>("output_num");
            var c1 = new ExpressionPart(inputNum1.Text.Replace(" ", "")).toComplexNumber();
            var c2 = new ExpressionPart(inputNum2.Text.Replace(" ", "")).toComplexNumber();
            var cb = this.FindControl<ComboBox>("select_action");
            switch (cb.SelectedItem) {
                case "+": outputNum.Text = ("" + (c1 + c2)); break;
                case "-": outputNum.Text = ("" + (c1 - c2)); break;
                case "*": outputNum.Text = ("" + c1 * c2); break;
                case "/": outputNum.Text = ("" + c1 / c2); break;
            }
            Console.WriteLine("clicked");
        }
    }
}