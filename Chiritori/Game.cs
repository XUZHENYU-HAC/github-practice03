using DxLibDLL;
using MyLib;

namespace Chiritori
{
    public class Game
    {
        public void Init()
        {
            MyRandom.Init();
            Input.Init();
        }

        public void Update()
        {
            Input.Update();
        }

        public void Draw()
        {
        }
    }
}
