using System;
using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Chip;

namespace ChipTest
{
    public class AppViewModel : PropertyChangedBase
    {
        public ObservableCollection<IDisplayable> collection;
        public ObservableCollection<IDisplayable> Collection
        {
            get
            {
                if(collection == null)
                {
                    collection = new ObservableCollection<IDisplayable>();
                    NotifyOfPropertyChange(() => Collection);
                }
                return collection;
            }
            set { collection = value; }
        }

        public AppViewModel()
        {
            Collection = new ObservableCollection<IDisplayable>();
            Enumerable.Range(1, 10).ToList().ForEach(_ => Collection.Add(new TableColumns { Name = Guid.NewGuid().ToString() }));
        }

        public void AddOne()
        {
            Collection.Add(new TableColumns
            {
                Name = Guid.NewGuid().ToString()
            });
        }
    }

    
}
