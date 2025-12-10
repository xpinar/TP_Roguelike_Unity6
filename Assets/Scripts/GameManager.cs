using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public BoardManager BoardManager;
    public PlayerController PlayerController;

    public TurnManager TurnManager { get; private set; }

    public static GameManager Instance { get; private set; }

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        //TurnManager = new TurnManager();

        //BoardManager.Init();
        //PlayerController.Spawn(BoardManager, new Vector2Int(1, 1));
    }
}
