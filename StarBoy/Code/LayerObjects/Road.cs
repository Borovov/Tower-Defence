using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace StarBoy
{
    class Road
    {
        public Texture2D tex;
        public Vector2 pos;

        public Road(Texture2D newRoadTex, Vector2 newRoadPos)
        {
            tex = newRoadTex;
            pos = newRoadPos;
        }
    }
}
