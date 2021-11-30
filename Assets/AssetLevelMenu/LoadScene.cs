using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject LoadingScreen;
    public GameObject LoadingScreen1;
    public GameObject LoadingScreen2;
    public GameObject LoadingScreen3;

    public void loadLevel1()
    {
        SceneManager.LoadScene("level1");
        // PanelOff();
    }

    public void loadLevel2()
    {
        Application.LoadLevel("level2");
        PanelOff();
    }

    // public void loadLevel3()
    // {
    //     Application.LoadLevel3("level3");
    // }

    public void Load1()
    {
        LoadingScreen.SetActive(true);
        LoadingScreen1.SetActive(true);
    }

    public void Load2()
    {
        LoadingScreen.SetActive(true);
        LoadingScreen2.SetActive(true);
    }

    // public void Load3()
    // {
    //     LoadingScreen3.SetActive(true);
    // }
    
    public void PanelOff()
    {
        LoadingScreen.SetActive(false);
        LoadingScreen1.SetActive(false);
        LoadingScreen2.SetActive(false);
        LoadingScreen3.SetActive(false);
    }
}
