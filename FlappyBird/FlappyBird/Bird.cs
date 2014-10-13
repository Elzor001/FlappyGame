using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace FlappyBird
{
	public class Bird
	{
		//Private variables.
		private static SpriteUV 	sprite;
		private static TextureInfo	textureInfo;
		public static int			pushAmount = 70;
		private static float		yPositionBeforePush;
		private static bool			rise;
		private static float		angle;
		private static bool			alive;
		public static int 			score = 0;
		public static string 		scoreString;
		private static int			count;
		public static float 		x;
		public static float 		y;
		
		public bool Alive { get{return alive;} set{alive = value;} }
		
		//Accessors.
		//public SpriteUV Sprite { get{return sprite;} }
		
		//Public functions.
		public Bird (Scene scene)
		{
			
			textureInfo  = new TextureInfo("/Application/textures/bird.png");
			
			sprite	 		= new SpriteUV();
			sprite 			= new SpriteUV(textureInfo);	
			sprite.Quad.S 	= textureInfo.TextureSizef;
			sprite.Position = new Vector2(50.0f,Director.Instance.GL.Context.GetViewport().Height*0.5f);
			//sprite.Pivot 	= new Vector2(0.5f,0.5f);
			angle = 0.0f;
			rise  = false;
			alive = true;
			
			//Add to the current scene.
			scene.AddChild(sprite);
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update(float deltaTime)
		{		
			scoreString = score.ToString();	
			count ++;
			Score ();
			//adjust the push
			if(rise)
			{
				//sprite.Rotate(0.008f);
				if( (sprite.Position.Y-yPositionBeforePush) < pushAmount)
					sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y + 3f);
				else
					rise = false;
					sprite.Angle = 0.5f;
			}
			else
			{
				//sprite.Rotate(-0.005f);
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y - 3);
				sprite.Angle = -0.5f;
			}
			
			
			x = sprite.Position.X;
			y = sprite.Position.Y;
			
			
			
			
		}	
		
		public void Score()
		{
	
			if(count ==60)
			{
			score++;
			count = 0;
			}
		}
		
		public void Tapped()
		{
			if(!rise)
			{
				rise = true;
				yPositionBeforePush = sprite.Position.Y;
			}
		}
	}
}

