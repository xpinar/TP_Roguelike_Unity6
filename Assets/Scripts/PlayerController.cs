using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private BoardManager m_Board;
    private Vector2Int m_CellPosition;
    // private Vector3 offset = new Vector3(0.0f, 0.0f, 0.0f); // Ajuste au besoin

    //private bool m_IsGameOver = false;

    public void Spawn(BoardManager boardManager, Vector2Int cell)
    {
        // TODO : stocker la référence au BoardManager
        // TODO : stocker la cellule actuelle

        // TODO : convertir la cellule en position monde
        // TODO : positionner le joueur à cette position: transform.position = ? 
    }

    public Vector2Int Cell
    {
        get { return m_CellPosition; }
    }
}
