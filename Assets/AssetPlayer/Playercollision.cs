using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Movement movement;
    public GameOver gameManager;
    public GameObject Checkpoints;
    public GameObject Checkpointbutton;
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
            Checkpointbutton.SetActive(true);
            Destroy(Checkpoints);
        }

        if(collision.transform.tag == "Finish")
        {
            movement.enabled = false;
            FindObjectOfType<GameOver>().Finish();
            Destroy(Finish);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
        {
            FindObjectOfType<Animasi>().AnimasiPopUp();
            FindObjectOfType<ColorChange>().Update();
        }
}
