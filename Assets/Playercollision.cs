using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Movement movement;
    public GameOver gameManager;
    public  GameObject Checkpoints;
    public GameObject Checkpointpanel;
    public Vector2 spawnPoint;
    public AudioSource src;
    public GameObject Finish;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            movement.enabled = false;
            FindObjectOfType<GameOver>().Endgame();
        }

        if(collision.transform.tag == "Checkpoint")
        {
            spawnPoint = Checkpoints.transform.position;
            Checkpointpanel.SetActive(true);
            Destroy(Checkpoints);
            Debug.Log(src.time);
            //33.792
        }

        if(collision.transform.tag == "Finish")
        {
            movement.enabled = false;
            FindObjectOfType<GameOver>().Finish();
            Destroy(Finish);
            // Unlock = 1;
            // int currentLevel = SceneManager.GetActiveScene().buildIndex;
            // if(currentLevel >= PlayerPrefs.GetInt("Levellock"))
            // {
            //     PlayerPrefs.SetInt("Levellock",currentLevel + 1);
                
            //     //for to go next level
            //     SceneManager.LoadScene(currentLevel + 1);
            // }
        }
    }
   

}
