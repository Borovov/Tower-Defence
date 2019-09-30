using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace StarBoy
{
    class Bush
    {
        public Texture2D tex;
        public Vector2 pos;

        public Bush(Texture2D newBushTex, Vector2 newBushPos)
        {
            tex = newBushTex;
            pos = newBushPos;
        }
    }
}
