using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace FlappyBird
{
	public class Menu
	{
		
		public static SpriteUV 	sprite;
		public static TextureInfo	textureInfo;
		
		public Menu (Scene scene)
		{
	
			
			

			
			
			
			
			
			textureInfo  		= new TextureInfo("/Application/textures/title.png");
			sprite	= new SpriteUV();
			sprite 			= new SpriteUV(textureInfo);
			sprite.Quad.S 	= textureInfo.TextureSizef;
			sprite.Position = new Vector2(0.0f, 0.0f);
			
			
			
			
	
			//foreach(SpriteUV sprite in sprite)
			scene.AddChild(sprite);
			
			sprite.Position = new Vector2(sprite.Position.X - 0.5f, sprite.Position.Y);
			
			//Touch.GetData(0).Clear();

			
		}
	}
}

