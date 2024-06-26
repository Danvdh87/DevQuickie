namespace LiveProject001;

public class IdleState : GameState
{
    public IdleState(GameManager gm) : base(gm)
    {
    }

    public override void Update()
    {
        _gm.uiManager.Update();
        _gm.map.UpdateTowerSelection();
    }

    public override void Draw()
    {
        _gm.map.Draw();
        _gm.uiManager.Draw();
        _gm.uiManager.DrawMonsterCounter(_gm.monstersInWave.Count);
        _gm.uiManager.DrawLiveCounter(_gm.PlayerLives);
        _gm.uiManager.DrawCustomLabel(_gm.WaveNumber.ToString(), new(10, 64));
    }
}
