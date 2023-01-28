using DxLibDLL;
using MyLib;

namespace Chiritori
{
    public class Game
    {
        public void Init()
        {
            Image.Load();
            MyRandom.Init();
            Input.Init();
        }

        public void Update()
        {
            Input.Update();
        }

        public void Draw()
        {
            DX.DrawGraph(0, 0, Image.woodFloor);
        }
    }
}
