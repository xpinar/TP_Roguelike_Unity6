using UnityEngine;

public class Enemy : CellObject
{
    public int Health = 3;

    private int m_CurrentHealth;

    private void Awake()
    {
        // TODO
    }

    private void OnDestroy()
    {
        // TODO
    }

    public override void Init(Vector2Int coord)
    {
        base.Init(coord);
        m_CurrentHealth = Health;
    }

    public override bool PlayerWantsToEnter()
    {
        // TODO
        return false;
    }


    bool MoveTo(Vector2Int coord)
    {
        // TODO
        return false;
    }

    void TurnHappened()
    {
        // TODO
    }

    bool TryMoveInX(int xDist)
    {
        // TODO
        return false;
    }

    bool TryMoveInY(int yDist)
    {
        // TODO
        return false;
    }
}
