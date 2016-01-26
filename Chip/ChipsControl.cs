using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chip
{
    public class ChipsControl : Control
    {
        static ChipsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChipsControl), new FrameworkPropertyMetadata(typeof(ChipsControl)));
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource",
                                                                                                        typeof(ObservableCollection<IDisplayable>),
                                                                                                        typeof(ChipsControl),
                                                                                                        new PropertyMetadata(new ObservableCollection<IDisplayable>()));
        public ObservableCollection<IDisplayable> ItemsSource
        {
            get
            {
                if ((ObservableCollection<IDisplayable>) GetValue(ItemsSourceProperty) == null)
                {
                    SetValue(ItemsSourceProperty, new ObservableCollection<IDisplayable>());
                }
                return (ObservableCollection<IDisplayable>) GetValue(ItemsSourceProperty);
            }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }

        public static DependencyProperty MaxDisplayedCharactersProperty = DependencyProperty.Register("MaxDisplayedCharacters",
                                                                                                            typeof(int),
                                                                                                            typeof(ChipsControl),
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

       private ICommand removeChipCommand;
       public ICommand RemoveChipCommand
        {
            get
            {
                if (removeChipCommand == null)
                {
                    removeChipCommand = new RemoveChip { Collection = ItemsSource };
                }

                return removeChipCommand;
            }

           set
           {
               removeChipCommand = value;
           }
        }
    }

    public class RemoveChip : ICommand
    {
        public ObservableCollection<IDisplayable> Collection;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Collection.Remove((IDisplayable) parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
