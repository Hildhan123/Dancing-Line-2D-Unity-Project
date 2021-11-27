using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;
    public Text scoreText1;
    //public string x,y;
    // Update is called once per frame
    public void Update()
    {
        scoreText.text = "Score " + Player.position.y.ToString("0");
        scoreText1.text = "Score " + Player.position.y.ToString("0");
    }


}
