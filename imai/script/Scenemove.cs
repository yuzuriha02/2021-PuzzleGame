using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemove : MonoBehaviour
{
     public string scenename;
     public void nextscene(string scenename)
     {        
          {
              SceneManager.LoadScene(scenename);             
          }
     }
 }