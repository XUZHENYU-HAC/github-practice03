using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace Chiritori
{ 
    public static class Image
    {
        public static int woodFloor;
        public static int chiritoriGreen;
        public static int chiritoriRed;
        public static int chiritoriBlue;
        public static int chiritoriYellow;
        public static int gomi;

        public static void Load()
        {
            woodFloor = DX.LoadGraph("Image/wood_floor.jpg");
            chiritoriGreen = DX.LoadGraph("Image/chiritori_green.png");
            chiritoriRed = DX.LoadGraph("Image/chiritori_red.png");
            chiritoriBlue = DX.LoadGraph("Image/chiritori_blue.png");
            chiritoriYellow = DX.LoadGraph("Image/chiritori_yellow.png");
            gomi = DX.LoadGraph("Image/gomi.png");
        }
    }
}
