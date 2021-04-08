using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.LiskovSubstitution.Models
{
    public class Square : Rectangle
    {
        public override void SetBase(double _base)
        {
            base.SetBase(_base);
            this.Altura = _base;
        }
    }
}
