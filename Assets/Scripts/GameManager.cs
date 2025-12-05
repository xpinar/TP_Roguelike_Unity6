using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public BoardManager BoardManager;
    public PlayerController PlayerController;

    public TurnManager TurnManager { get; private set; }

    //private int m_FoodAmount = 10;

    public UIDocument UIDoc;
    private Label m_FoodLabel;

    private VisualElement m_GameOverPanel;
    private Label m_GameOverMessage;

    public int m_CurrentLevel = 1;

    private void Awake()
    {

        // TODO : Singleton pattern
    }

    void Start()
    {
        // TODO
    }

    public void StartNewGame()
    {
        // TODO
    }

    public void NewLevel()
    {
        // TODO
    }

    void OnTurnHappen()
    {
        // TODO
    }

    public void ChangeFood(int amount)
    {
        // TODO
    }
}