using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class RandomZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;    // Reference to the zombie prefab
    public int gridRows = 10;          // Number of rows in the grid
    public int gridColumns = 10;       // Number of columns in the grid
    public float cellSize = 2f;        // Distance between each grid cell
    public int zombieCount = 20;       // Number of zombies to spawn

    void Start()
    {
        SpawnZombiesOnGrid();
    }

    void SpawnZombiesOnGrid()
    {
        for (int i = 0; i < zombieCount; i++)
        {
            // Pick a random position in the grid
            int row = Random.Range(0, gridRows);
            int column = Random.Range(0, gridColumns);

            // Calculate the position based on the grid coordinates
            Vector3 position = new Vector3(row * cellSize, 0, column * cellSize);

            // Instantiate a zombie at the calculated position
            Instantiate(zombiePrefab, position, Quaternion.identity);
        }
    }
}



