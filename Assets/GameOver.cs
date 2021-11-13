using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    bool gameselesai = false;
    public GameObject Gameoverpanel;
    public GameObject player;
    public Playercollision spawn;
    public AudioSource src2;
    public AudioSource src1;
    public TrailRenderer tr;
    public Text text;
    int onetime = 1;

    public void Start()
    {
        Time.timeScale = 0;
    }
    
    public void Update()
    {
        if(onetime == 1)
        {
            if(Input.GetKey("z") || Input.GetKey("x"))
            {
                Destroy(text);
                src1.Play();
                Time.timeScale = 1; 
                Debug.Log(src1.time);
                onetime++;
            }
        }
    }
    public void Endgame()
    {
        if(gameselesai == false)
        {
            gameselesai = true;
            Gameoverpanel.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }

    public void checkpoint()
    {
        player.transform.position = spawn.spawnPoint;
        gameselesai = false;
        Gameoverpanel.SetActive(false);
        FindObjectOfType<Movement>().arah = 0;
        FindObjectOfType<Movement>().enabled = true;
        src1.Stop();
        src2.Play();
        tr.Clear();
    }
}
    
