using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    int Levellock;
    public Button[] levelbuttons;

    private void Start()
    {
        Levellock = PlayerPrefs.GetInt("Levellock",1);

        for(int i = 0; i < levelbuttons.Length; i++)
        {
            levelbuttons[i].interactable = false;
        }

        for(int i = 0; i < Levellock; i++)
        {
            levelbuttons[i].interactable = true;
        }
    }

    public void openLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
