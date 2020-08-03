using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.ValueObjects
{
    public class Dimension:ValueObject
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Length;
            yield return Height;
            yield return Width;
        }
    }
}
