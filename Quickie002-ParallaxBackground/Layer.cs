namespace Quickie002;

public class Layer(Texture2D texture, float depth, float moveScale, float defaultSpeed = 0.0f)
{
    private readonly Texture2D _texture = texture;
    private Vector2 _position = Vector2.Zero;
    private Vector2 _position2 = Vector2.Zero;
    private readonly float _depth = depth;
    private readonly float _moveScale = moveScale;
    private readonly float _defaultSpeed = defaultSpeed;

    public void Update(float movement)
    {
        _position.X += ((movement * _moveScale) + _defaultSpeed) * Globals.ElapsedSeconds;
        _position.X %= _texture.Width;

        if (_position.X >= 0)
        {
            _position2.X = _position.X - _texture.Width;
        }
        else
        {
            _position2.X = _position.X + _texture.Width;
        }
    }

    public void Draw()
    {
        Globals.SpriteBatch.Draw(_texture, _position, null, Color.White, 0, Vector2.Zero, Vector2.One, SpriteEffects.None, _depth);
        Globals.SpriteBatch.Draw(_texture, _position2, null, Color.White, 0, Vector2.Zero, Vector2.One, SpriteEffects.None, _depth);
    }
}
