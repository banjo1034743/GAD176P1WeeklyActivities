using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public float gameTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager Instance
    {
        get { return instance; }
    }

    private void Update()
    {
        gameTime += Time.deltaTime;
    }
}
