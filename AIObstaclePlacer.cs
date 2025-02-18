using UnityEngine;

public class AIObstaclePlacer : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int numberOfObstacles = 10;

    void Start()
    {
        PlaceObstacles();
    }

    void PlaceObstacles()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10));
            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }
    }
}
