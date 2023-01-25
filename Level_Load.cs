using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Code : MonoBehaviour
{     public GameObject off1;
      public GameObject off_;
      public GameObject Open_;
      public GameObject Open1;
      public GameObject off2;
      public GameObject Open2;

   public void PlayButton() 
   {
     SceneManager.LoadScene(1);
     
   }

   public void ExitButton() 
   {
      Application.Quit();
   }

   public void Chapter1() 
   {
      SceneManager.LoadScene(2);
      //Time.timeScale=0; 
   }
     
    public void Chapter2() 
   {
      SceneManager.LoadScene(3);
      //Time.timeScale=0;
   }

   public void Chapter3() 
   {
      SceneManager.LoadScene(4);
      //Time.timeScale=0;
   }

    public void Chapter4() 
   {
      SceneManager.LoadScene(5);
      //Time.timeScale=0;
   }
   
    public void Chapter5() 
   {
      SceneManager.LoadScene(6);
      //Time.timeScale=0;
   }
  
   public void Chapter_6() 
   {
      SceneManager.LoadScene(7);
      //Time.timeScale=0;
   }

   public void Chapter_7() 
   {
      SceneManager.LoadScene(8);
      //Time.timeScale=0;
   }

   public void Chapter_8() 
   {
      SceneManager.LoadScene(9);
      //Time.timeScale=0;
   }

   public void Chapter_9() 
   {
      SceneManager.LoadScene(10);
      //Time.timeScale=0;
   }

   public void Chapter_10() 
   {
      SceneManager.LoadScene(11);
      //Time.timeScale=0;
   }

   public void Chapter_11() 
   {
      SceneManager.LoadScene(12);
      //Time.timeScale=0;
   }

   public void Chapter_12() 
   {
      SceneManager.LoadScene(13);
      //Time.timeScale=0;
   }

   public void Chapter_13() 
   {
      SceneManager.LoadScene(14);
      //Time.timeScale=0;
   }

   public void Enter_easy()
   {
      Open1.SetActive(true);
      Open_.SetActive(false);
      off_.SetActive(false);
   }
    public void Exit_easy()
   {
      off1.SetActive(false);
      Open_.SetActive(true);
      off_.SetActive(true);
   }

    public void Enter_easy1()
   {
      Open2.SetActive(true);
      Open_.SetActive(false);
      off_.SetActive(false);
   }

    public void Exit_easy1()
   {
      off2.SetActive(false);
      Open_.SetActive(true);
      off_.SetActive(true);

   }


}