using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            GameOver.isGameOver = true;
            Movement.moveSpeed = 0;
        }
    }
}
