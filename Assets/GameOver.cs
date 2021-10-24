using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    private void Awake()
    {
        isGameOver = false;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
        gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel1()
    {
        Debug.Log("berhasil");
        SceneManager.LoadScene("Level1");
    }
}
