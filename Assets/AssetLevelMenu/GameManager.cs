using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelPause;
    public bool spawnpoint;
    public AudioSource src1;
    public AudioSource src2;

    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;

            if(spawnpoint == true)
            {
                src2.Pause();
            }
            else
            {
                src1.Pause();
            }
        }

        else
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);

            if(spawnpoint == true)
            {
                src2.Play();
            }
            else
            {
                src1.Play();
            }
        }
    }


}
