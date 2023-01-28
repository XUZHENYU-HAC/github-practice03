using DxLibDLL;
using MyLib;

namespace Chiritori
{
    public class Game
    {
        Chiritori chiritori;
        Gomi gomi; // ゴミ
        public void Init()
        {
            Image.Load();
            MyRandom.Init();
            Input.Init();
            chiritori = new Chiritori();
            gomi = new Gomi();
        }

        public void Update()
        {
            Input.Update();

            chiritori.Update();
        }

        public void Draw()
        {
            DX.DrawGraph(0, 0, Image.woodFloor);
            gomi.Draw();
            chiritori.Draw();
        }
    }
}
