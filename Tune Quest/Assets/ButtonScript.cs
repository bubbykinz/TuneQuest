using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button resetButton;

    void OnEnable()
    {
        //Register Button Event
        resetButton.onClick.AddListener(() => buttonCallBack());
    }

    private void buttonCallBack()
    {
        UnityEngine.Debug.Log("Clicked: " + resetButton.name);

        //Get current scene name
        string scene = SceneManager.GetActiveScene().name;
        //Load it
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    void OnDisable()
    {
        //Un-Register Button Event
        resetButton.onClick.RemoveAllListeners();
    }
}


