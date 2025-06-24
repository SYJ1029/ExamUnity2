using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public GameObject wallPrefab;
    public int width = 11;
    public int height = 11;
    public float cellSize = 4f;


    private int[,] maze = new int[11, 11] {
    {1,1,1,1,1,1,1,1,1,1,1},
    {1,0,1,0,0,0,0,0,0,0,1},
    {1,0,1,0,1,1,1,0,1,0,1},
    {1,0,1,0,1,0,0,0,1,0,1},
    {1,0,1,1,1,0,1,1,1,0,1},
    {1,0,0,0,0,0,1,0,0,0,1},
    {1,0,1,1,1,1,1,0,1,1,1},
    {1,0,1,0,0,0,0,0,1,0,1},
    {1,0,1,0,1,1,1,1,1,0,1},
    {1,0,0,0,0,0,0,0,0,0,1},
    {1,1,1,1,1,1,1,1,1,1,1},
    };

    void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (maze[y, x] == 1)
                {
                    Vector3 position = new Vector3(x * cellSize - 100, 0, y * cellSize - 100);
                    Instantiate(wallPrefab, position, Quaternion.identity, transform);
                }
            }
        }
    }
}
