using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using StarBoy.Code.Enemies;

namespace StarBoy.Code
{
    class Soldier : Enemy
    {

        public Soldier(Texture2D newTex, Vector2 newPos, int newHp) : base(newTex, newPos, newHp)
        {
            
        }

    }
}
