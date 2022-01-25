using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numberDrawers { get; set; }
        public SurfaceMaterial surface { get; set; }

        public Desk(int width, int depth, int numberDrawers, SurfaceMaterial surface)
        {
            this.width = width;
            this.depth = depth;
            this.numberDrawers = numberDrawers;
            this.surface = surface;
        }




    }
}
