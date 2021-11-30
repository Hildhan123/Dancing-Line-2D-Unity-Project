using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneS : MonoBehaviour
{

    public Slider loadingBar;
    public GameObject panelLoading;
    bool isStart; //false
    
    void Start()
    {
        
    }

    void Update()
    {
        if(isStart == true)
        {
            if (loadingBar.value != loadingBar.maxValue)
            {
                loadingBar.value += Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void ButtonLoadScene()
    {
        isStart = true;
        panelLoading.SetActive(true);
    }
}
