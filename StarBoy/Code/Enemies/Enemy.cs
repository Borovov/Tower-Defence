using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace StarBoy.Code.Enemies
{
    class Enemy
    {
        public Texture2D tex;
        public Vector2 pos;
        public int hp;
        public int damage;
        public float speed = 1.5f;
        private int[,] map  = new MapSetter().getLayer();

        public Enemy(Texture2D newTex, Vector2 newPos, int newHp)
        {
            tex = newTex;
            pos = newPos;
            hp = newHp;
        }
        
        public void walk()
        {
            pos.X -= speed;


        }
    }
}
