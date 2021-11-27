using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    bool gameselesai = false;
    public GameObject Gameoverpanel;
    public GameObject player;
    private Vector2 spawn;
    public AudioSource src2;
    public AudioSource src1;
    private TrailRenderer tr;
    public Text text;
    int onetime = 1;
    public GameObject FinishPanel;

    public void Start()
    {
        Time.timeScale = 0;
        //agar waktu berhenti
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
        spawn = FindObjectOfType<Playercollision>().spawnPoint;
        tr = FindObjectOfType<TrailRenderer>();
        player.transform.position = spawn;
        gameselesai = false;
        Gameoverpanel.SetActive(false);
        FindObjectOfType<Movement>().arah = 0;
        FindObjectOfType<Movement>().enabled = true;
        src1.Stop();
        src2.Play();
        tr.Clear();
        FindObjectOfType<Animasi>().restartpopup();
        FindObjectOfType<GameManager>().spawnpoint = true;
        FindObjectOfType<Movement>().Timer = 33.80222f;
        
    }

    public void Finish()
    {
        FinishPanel.SetActive(true);
    }
}
    
