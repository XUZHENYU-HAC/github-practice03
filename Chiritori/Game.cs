using DxLibDLL;
using MyLib;
using System;

namespace Chiritori
{
    public class Game
    {
        Chiritori[] chiritories;
        Gomi gomi; // ゴミ
        int[] scores;

        public void Init()
        {
            Image.Load();
            MyRandom.Init();
            Input.Init();
            chiritories = new Chiritori[2]; // チリトリーの配列を生成
            chiritories[0] = new Chiritori(DX.PAD_INPUT_1, Image.chiritoriGreen); // Player1生成
            chiritories[1] = new Chiritori(DX.PAD_INPUT_2, Image.chiritoriRed); // Player2生成
            scores = new int[2];
            gomi = new Gomi();
        }

        public void Update()
        {
            Input.Update();

            for (int i = 0; i < chiritories.Length; i++)
            {
                Chiritori chiritori = chiritories[i];
                chiritori.Update();

                float deltaX = chiritori.x - gomi.x; // x方向の差分
                float deltaY = chiritori.y - gomi.y; // y方向の差分
                float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY); // 距離

                // 距離が50以下なら
                if (distance <= 50)
                {
                    scores[i] += 1;
                    gomi.ResetPosition(); // ゴミの場所をリセット
                }
            }
        }

        public void Draw()
        {
            DX.DrawGraph(0, 0, Image.woodFloor);
            gomi.Draw();
            for (int i = 0; i < chiritories.Length; i++)
            {
                chiritories[i].Draw();
            }

            // スコアを描画
            for (int i = 0; i < scores.Length; i++)
            {
                DX.DrawString(300 + 60 * i, 20, scores[i].ToString(), DX.GetColor(255, 255, 255));
            }
        }
    }
}
