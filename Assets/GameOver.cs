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
        src1.Stop();
        src2.Play();
        tr.Clear();
    }
}
    
