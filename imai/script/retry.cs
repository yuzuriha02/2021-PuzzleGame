using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class retry : MonoBehaviour
{
public void RetryButton()
    {
        SceneManager.LoadScene(Data.Instance.referer);
    }
}



