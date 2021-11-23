using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenuS : MonoBehaviour
{
    // public Text scoreText;

    public void BukaLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void BukaLevelMenu1()
    {
        SceneManager.LoadScene("LevelMenu1");
    }

    public void BukaLevelMenu2()
    {
        SceneManager.LoadScene("LevelMenu2");
    }

    public void BukaLevelMenu3()
    {
        SceneManager.LoadScene("LevelMenu3");
    }

    public void BukaLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void BukaLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void BukaLevel3()
    {
        SceneManager.LoadScene("Level1");
    }

    public void BukaMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // public void Update()
    // {
    //     scoreText = FindObjectOfType<Score>().scoreText.Text;
    // }
}
