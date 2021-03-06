using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        gameObject.SetActive(false);
        FindObjectOfType<ProgressSceneLoader>().LoadScene(sceneToLoad);
    }

}
