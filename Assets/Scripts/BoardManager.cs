using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour
{
    public class CellData
    {
        public bool Passable;
        public CellObject ContainedObject;
    }

    private CellData[,] m_BoardData;

    private Tilemap m_Tilemap;

    private Grid m_Grid;

    public int Width;
    public int Height;
    public Tile[] GroundTiles;
    public Tile[] WallTiles;

    public FoodObject FoodPrefab;

    private List<Vector2Int> m_EmptyCellsList;
    public ExitCellObject ExitCellPrefab;

    public Enemy EnemyPrefab;

    public void Init()
    {
        m_Tilemap = GetComponentInChildren<Tilemap>();
        m_Grid = GetComponentInChildren<Grid>();

        m_EmptyCellsList = new List<Vector2Int>();

        m_BoardData = new CellData[Width, Height];


        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; ++x)
            {
                // TODO
            }
        }
        
        //TODO
    }

    public Vector3 CellToWorld(Vector2Int cellIndex)
    {
        // TODO
        return Vector3.zero;
    }

    public CellData GetCellData(Vector2Int cellIndex)
    {
       //TODO
       return null;
    }

    void GenerateFood()
    {
        int foodCount = 2;
        for (int i = 0; i < foodCount; ++i)
        {
            //TODO
        }
    }

    public void SetCellTile(Vector2Int cellIndex, Tile tile)
    {
        //TODO
    }

    void AddObject(CellObject obj, Vector2Int coord)
    {
        //TODO
    }

    public Tile GetCellTile(Vector2Int cellIndex)
    {
       //TODO
       return null;
    }

    public void Clean()
    {
        /*if (m_BoardData == null)
            return;*/


        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; ++x)
            {
                //TODO
            }
        }
    }

    void GenerateEnemies()
    {
        //TODO
    }

}
