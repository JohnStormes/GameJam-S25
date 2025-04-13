using UnityEngine;
using UnityEngine.UI;

public class SceneCrossObject : MonoBehaviour
{
    public static SceneCrossObject Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}