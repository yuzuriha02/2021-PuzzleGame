using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name_list : MonoBehaviour
{
    int MAXMENBER = 10;
    string[] menbers = new string[10];
    string men1 = "kaneko"; 
    string men2 = "suzuki";

    // Start is called before the first frame update
    void Start()
    {
        menbers[0] = men1;
        menbers[1] = men2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
