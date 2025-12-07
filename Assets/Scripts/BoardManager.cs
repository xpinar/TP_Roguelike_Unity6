using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour
{
    //public class CellData
    //{
    //    public bool Passable;
    //    public GameObject ContainedObject;
    //}

    //private CellData[,] m_BoardData;

    private Tilemap m_Tilemap;

    //private Grid m_Grid;

    public int Width;
    public int Height;
    public Tile[] GroundTiles;
    
    //public Tile[] WallTiles;

    //public GamObject FoodPrefab;

    //private List<Vector2Int> m_EmptyCellsList;
    //public ExitCellObject ExitCellPrefab;

    //public Enemy EnemyPrefab;

    void Start()
    {
        m_Tilemap = GetComponentInChildren<Tilemap>();

        //m_Grid = GetComponentInChildren<Grid>();
        //m_EmptyCellsList = new List<Vector2Int>();
        //m_BoardData = new CellData[Width, Height];


        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; ++x)
            {
                int tileNumber = Random.Range(0, GroundTiles.Length);
                m_Tilemap.SetTile(new Vector3Int(x, y, 0), GroundTiles[tileNumber]);
            }
        }
    }
}
