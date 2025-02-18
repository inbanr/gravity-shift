using UnityEngine;

public class ProceduralTerrain : MonoBehaviour
{
    public int width = 10;
    public int depth = 10;
    public float scale = 5f;
    public GameObject platformPrefab;

    void Start()
    {
        GenerateTerrain();
    }

    void GenerateTerrain()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                float y = Mathf.PerlinNoise(x * 0.3f, z * 0.3f) * scale;
                Vector3 position = new Vector3(x, y, z);
                Instantiate(platformPrefab, position, Quaternion.identity);
            }
        }
    }
}
