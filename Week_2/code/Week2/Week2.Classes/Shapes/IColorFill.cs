using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Shapes
{
    interface IColorFill
    {
        System.Drawing.Color Color { get; set; }

        void Fill();
    }
}
