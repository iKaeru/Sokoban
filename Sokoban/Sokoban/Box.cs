using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sokoban
{
    public class Box : IGameElement
    {
        public Texture2D Texture { get; }

        public Box(Texture2D texture)
        {
            Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,
                new Rectangle(0, 0, Constants.FieldCellWidth, Constants.FieldCellHeight), // todo: add coordinates
                Color.White);
        }
    }
}