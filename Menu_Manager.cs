using System.Security.Cryptography;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public GameObject Pause;
    public GameObject Pause_Player;
    public GameObject Main_Menu;
    public void PauseButton()
    {
      
        Time.timeScale=0;
        Pause.SetActive(true);
        Pause_Player.SetActive(false);

    }

   

    public void ExitPause() 
    {
        Time.timeScale=1f;       
        Pause_Player.SetActive(true);
        Pause.SetActive(false);
    }

    public void RePlay1()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(2);
      
    }
     public void RePlay2()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(3);
      
    }
     public void RePlay3()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(4);
      
    }
     public void RePlay4()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(5);
      
    }

    public void RePlay5()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(6);
      
    }
     public void RePlay6()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(7);
      
    }

     public void RePlay7()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(8);
      
    }

     public void RePlay8()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(9);      
    }

     public void RePlay9()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(10);
      
    }

     public void RePlay10()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(11);
      
    }

     public void RePlay11()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(12);
      
    }
     public void RePlay12()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(13);
      
    }
     public void RePlay13()
    {
        Time.timeScale=1f;      
         SceneManager.LoadScene(14);
      
    }

   
    
    public void main_menu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale=1f; 
    }

    public void Menu_Main() 
    {
        SceneManager.LoadScene(0);
    }
}
