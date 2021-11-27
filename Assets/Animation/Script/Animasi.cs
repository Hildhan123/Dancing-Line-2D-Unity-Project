using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject popup1;
    public GameObject popup2;
    public GameObject popup3;
    public GameObject popup4;
    public GameObject popup5;
    public GameObject popup6;
    public GameObject popup7;
    public GameObject popup8;
    public GameObject popup9;
    public GameObject popup10;
    public GameObject popup11;
    public GameObject popup12;
    public GameObject popup13;
    public GameObject popup14;
    public GameObject popup15;
    public GameObject popup16;

    public void AnimasiPopUp()
    {
        if(player.transform.position.y > 22f)
        {
            popup1.SetActive(true);
        }

        if(player.transform.position.y > 28f)
        {
            popup2.SetActive(true);
        }
        if(player.transform.position.y > 38f)
        {
            popup3.SetActive(true);
        }
        if(player.transform.position.y > 60f)
        {
            popup4.SetActive(true);
        }
        if(player.transform.position.y > 65f)
        {
            popup5.SetActive(true);
        }
        if(player.transform.position.y > 86f)
        {
            popup6.SetActive(true);
        }
        if(player.transform.position.y > 93f)
        {
            popup7.SetActive(true);
        }
        if(player.transform.position.y > 101f)
        {
            popup8.SetActive(true);
        }
        if(player.transform.position.y > 102f)
        {
            popup9.SetActive(true);
        }
        if(player.transform.position.y > 116f)
        {
            popup10.SetActive(true);
        }
        if(player.transform.position.y > 126f)
        {
            popup11.SetActive(true);
        }
        if(player.transform.position.y > 142f)
        {
            popup12.SetActive(true);
        }
        if(player.transform.position.y > 153f)
        {
            popup13.SetActive(true);
        }
        if(player.transform.position.y > 168f)
        {
            popup14.SetActive(true);
        }
        if(player.transform.position.y > 182f)
        {
            popup15.SetActive(true);
        }
        if(player.transform.position.y > 190f)
        {
            popup16.SetActive(true);
        }
        /*
            22
            28
            38
            60
            65
            86
            93
            101
            108
            116
            126
            142
            153
            168
            182
            200
        */
    }

    public void restartpopup()
    {
        popup7.SetActive(false);
        popup8.SetActive(false);
        popup9.SetActive(false);
        popup10.SetActive(false);
        popup11.SetActive(false);
        popup12.SetActive(false);
        popup13.SetActive(false);
        popup14.SetActive(false);
        popup15.SetActive(false);
        popup16.SetActive(false);
    }
}
