using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightCrowd.Chip
{
    public interface IChipItem<T>
    {
        T Value { get; set; }
        string DisplayValue { get; set; }
    }
}
