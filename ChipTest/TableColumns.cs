using System.Windows.Input;
using Chip;

namespace ChipTest
{
    public class TableColumns: IDisplayable
    {
        public string Name;
        public string DisplayText => Name;
    }
}
