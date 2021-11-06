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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            //movement.enabled = false;
            FindObjectOfType<GameOver>().Endgame();
        }

        if(collision.transform.tag == "Checkpoint")
        {
            spawnPoint = Checkpoints.transform.position;
            Checkpointpanel.SetActive(true);
            Destroy(Checkpoints);
        }
    }
   

}
