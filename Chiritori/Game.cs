using DxLibDLL;
using MyLib;

namespace Chiritori
{
    public class Game
    {
        Chiritori chiritori;
        public void Init()
        {
            Image.Load();
            MyRandom.Init();
            Input.Init();
            chiritori = new Chiritori();
        }

        public void Update()
        {
            Input.Update();

            chiritori.Update();
        }

        public void Draw()
        {
            DX.DrawGraph(0, 0, Image.woodFloor);

            chiritori.Draw();
        }
    }
}
