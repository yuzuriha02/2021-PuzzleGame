using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemove : MonoBehaviour
{
     private bool firstPush = false;
     public string scenename;

     public void nextscene(string scenename)
     {
          //Debug.Log("Press Start!");
          if (!firstPush)
          {
              //Debug.Log("Go Next Scene!");
              SceneManager.LoadScene(scenename);
              firstPush = true;
          }
     }
 }