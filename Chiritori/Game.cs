using DxLibDLL;
using MyLib;
using System;

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

            float deltaX = chiritori.x - gomi.x; // x方向の差分
            float deltaY = chiritori.y - gomi.y; // y方向の差分
            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY); // 距離

            // 距離が50以下なら
            if (distance <= 50)
            {
                gomi.ResetPosition(); // ゴミの場所をリセット
            }
        }

        public void Draw()
        {
            DX.DrawGraph(0, 0, Image.woodFloor);
            gomi.Draw();
            chiritori.Draw();
        }
    }
}
