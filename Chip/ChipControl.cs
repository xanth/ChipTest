using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Chip
{
    public class ChipControl : Control
    {
        static ChipControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChipControl), new FrameworkPropertyMetadata(typeof(ChipControl)));

        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", 
                                                                                                typeof(string), 
                                                                                                typeof(ChipControl), 
                                                                                                new PropertyMetadata(null));

        public string Text
        {
            get
            {
                return (string) GetValue(TextProperty); 
            }
            set
            {
                SetValue(TextProperty, value);           
            }
        }

        public static DependencyProperty RemoveChipCommandProperty = DependencyProperty.Register("RemoveChipCommand", 
                                                                                                    typeof(ICommand), 
                                                                                                    typeof(ChipControl), 
                                                                                                    new PropertyMetadata(null));
        public ICommand RemoveChipCommand
        {
            get
            {
                return (ICommand)GetValue(RemoveChipCommandProperty);
            }

            set
            {
                SetValue(RemoveChipCommandProperty, value);
            }
        }

        public static DependencyProperty RemoveChipCommandParameterProperty = DependencyProperty.Register("RemoveChipCommandParameter", 
                                                                                                            typeof(object), 
                                                                                                            typeof(ChipControl),
                                                                                                            new PropertyMetadata(null));
        public object RemoveChipCommandParameter
        {
            get
            {
                return GetValue(RemoveChipCommandParameterProperty);
            }

            set
            {
                SetValue(RemoveChipCommandParameterProperty, value);
            }
        }
    }
}
