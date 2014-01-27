
#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion
#region shortcuts
using Tex = Microsoft.Xna.Framework.Graphics.Texture2D;
using V2 = Microsoft.Xna.Framework.Vector2;
using Rec = Microsoft.Xna.Framework.Rectangle;
using C = Microsoft.Xna.Framework.Color;
using SE = Microsoft.Xna.Framework.Graphics.SpriteEffects;
using F = System.Single;
#endregion

namespace WindowsGame2
{
    class Drawing : Ifocus
    {
        #region Data
        protected Tex tex;
        //private Tex pausingBack;
        protected V2 org;
        protected Rec? rec;
        public V2 Pos{get; set;}
       protected C color;
        public F Rot{get; set;}
        V2 scale;        
        protected SE effect;
        F layer;
        #endregion

        #region ctor
        public Drawing(Tex texture,
                         V2 position,
                         Rec? sourceRectangle,
                         C color,
                         F rotation,
                         V2 origin,
                         V2 scale,
                         SE effects,
                         F layerDepth)
        {
            this.tex = texture;
            this.Pos = position;
            this.rec = sourceRectangle;
            this.color = color;
            this.Rot = rotation;
            this.org = origin;
            this.scale = scale;
            this.effect = effects;
            this.layer = layerDepth;
          
        }
        #endregion


        #region Draw
        public virtual void draw()
        {
            if (Game1.isPaused)
            {
                Game1.spriteBatch.Draw(tex, Pos, rec, color * 0.5f, Rot, org, scale, effect, layer);
            }
            else
            {
                Game1.spriteBatch.Draw(tex, Pos, rec, color, Rot, org, scale, effect, layer);            
            }
        }
        #endregion

        #region MyRegion
        //#region Update
        //public void update()
        //{
        //    rotate();
        //    move();
        //}
        //#endregion

        //#region private
        //private void rotate()
        //{
        //    if (Keyboard.GetState().IsKeyDown((Keys)39))
        //    {
        //        rot += 0.02f;
        //    }
        //    if (Keyboard.GetState().IsKeyDown(Keys.Left))
        //    {
        //        rot -= 0.02f;
        //    }
        //}
        //private void move()
        //{
        //    V2 step = -V2.UnitY;
        //    Matrix mat = Matrix.CreateRotationZ(rot);
        //    step = V2.Transform(step, mat);

        //    if (Keyboard.GetState().IsKeyDown(Keys.Up))
        //    {
        //        pos += step;
        //    }
        //    if (Keyboard.GetState().IsKeyDown(Keys.Down))
        //    {
        //        pos -= step;
        //    }
        //}
        //#endregion 
        #endregion
    }
}
