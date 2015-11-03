using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Box2DX;
using Box2DX.Dynamics;
using Box2DX.Collision;
using Box2DX.Common;
using UnityEngine;


namespace Assets
{
    public class Test
    {

        public Test()
        {
            AABB aabb = new AABB();
            aabb.UpperBound = new UnityEngine.Vector2(100,100);
            aabb.LowerBound = new UnityEngine.Vector2(-100,-100);
            World world = new World(aabb, new Vector2(0, -1), false);
            BodyDef groundBodyDef = new BodyDef();
            groundBodyDef.Position.Set(0, 0);
            PolygonShape groundBox = new PolygonShape();
            groundBox.SetAsBox(10, 1);
            Body body = new Body(groundBodyDef, world);
        }
    }
}
