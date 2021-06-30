using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintSkilDetails : MonoBehaviour
{
    Text text;
    public GameObject comandManager;
    public string comandName;
    // Start is called before the first frame update
    void Start()
    {
        comandValue cv = comandManager.GetComponent<comandValue>();
        text = GetComponent<Text>();
        
    }
}
