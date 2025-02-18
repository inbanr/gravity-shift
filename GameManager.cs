using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}
