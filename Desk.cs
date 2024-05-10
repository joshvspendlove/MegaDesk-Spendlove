using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Spendlove
{
    public enum DesktopMaterial
    {
        [Description("Laminate")]
        LAMINATE,
        [Description("Oak")]
        OAK,
        [Description("Rosewood")]
        ROSEWOOD,
        [Description("Veneer")]
        VENEER,
        [Description("Pine")]
        PINE
    }

    public class Desk
    {
        public const int MAX_WIDTH = Globals.MAX_WIDTH;
        public const int MIN_WIDTH = Globals.MIN_WIDTH;
        public const int MAX_DEPTH = Globals.MAX_DEPTH;
        public const int MIN_DEPTH = Globals.MIN_DEPTH;

        private int width, depth, numDrawers, area;
        private DesktopMaterial material;
        public Desk(int width, int depth, int numDrawers, DesktopMaterial material)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.material = material;

            calculateArea();
        }

        private void calculateArea() { area = width * depth; }

        public int GetArea() { return area; }

        public DesktopMaterial GetMaterial() { return material; }

        public void SetWidth(int width)
        {
            this.width = width;
            calculateArea();
        }

        public void SetDepth(int depth)
        {
            this.depth = depth;
            calculateArea();
        }

        public void SetMaterial(DesktopMaterial material)
        {
            this.material = material;
        }

        public int GetNumDrawers()
        {
            return numDrawers;
        }

        public int GetWidth() { return width; }

        public int GetDepth() { return depth; }

        public void SetNumDrawers(int numDrawers)
        {
            this.numDrawers = numDrawers;
        }
    }
}
