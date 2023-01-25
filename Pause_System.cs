using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chapter_Code : MonoBehaviour
{   
    public GameObject PauseA,ElementsA;
    public void PauseButton()
    {
      
        Time.timeScale=0;
        PauseA.SetActive(true);
        ElementsA.SetActive(false);

    }
}