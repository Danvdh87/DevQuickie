namespace Project003;

public class PlayState : GameState
{
    public PlayState(GameManager gm) : base(gm)
    {
    }

    public override void Update()
    {
        _gm.monsterManager.Update();
        _gm.AssignTargets();
        _gm.map.UpdateTowers();
    }

    public override void Draw()
    {
        _gm.map.Draw();
        _gm.monsterManager.Draw();
        _gm.monsterManager.DrawHPBars();
        _gm.map.DrawProjectiles();
        _gm.uiManager.DrawMonsterCounter(_gm.monsterManager.Monsters.Count);
    }
}
