using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private BoardManager m_Board;
    private Vector2Int m_CellPosition;
    // private Vector3 offset = new Vector3(0.0f, 0.0f, 0.0f); // Adjust as needed

    //private bool m_IsGameOver = false;

    public void Spawn(BoardManager boardManager, Vector2Int cell)
    {
        // TODO: reset player state
    }

    public void Init()
    {
       // TODO
    }

    private void Update()
    {
        Vector2Int newCellTarget = m_CellPosition;
        bool hasMoved = false;

        // TODO: Get input and move player

        if (hasMoved)
        {
            // TODO
        }


    }

    void MoveTo(Vector2Int cell)
    {
        // TODO
    }

    public void GameOver()
    {
        // TODO
    }

    public Vector2Int Cell
    {
        get { return m_CellPosition; }
    }

}
