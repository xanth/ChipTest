﻿using System.Windows;
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

        //public override void OnApplyTemplate()
        //{
        //    var textbox = Template.FindName("ChipText", this) as TextBlock;
        //    if (textbox != null)
        //        textbox.Text = "Roman was right";
        //}

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", 
                                                                                                typeof(string), 
                                                                                                typeof(ChipControl), 
                                                                                                new PropertyMetadata(null));

        
        public string DisplayText
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

        public static DependencyProperty MaxDisplayedCharactersProperty = DependencyProperty.Register("MaxDisplayedCharacters",
                                                                                                            typeof(int),
                                                                                                            typeof(ChipControl),
                                                                                                            new PropertyMetadata(9));
        public int MaxDisplayedCharacters
        {
            get
            {
                return (int)GetValue(MaxDisplayedCharactersProperty);
            }
            set
            {
                SetValue(MaxDisplayedCharactersProperty, value);
            }
        }
    }
}
