using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public BoardManager BoardManager;
    public PlayerController PlayerController;

    //public TurnManager TurnManager { get; private set; }

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        // TODO : initialiser le singleton
    }

    void Start()
    {
        // TODO : “instancier” et créer les objets
    }
}
