using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hp_controll : MonoBehaviour
{
    int hp;
    private Text hp_text;
    // Start is called before the first frame update
    void Start()
    {
        hp_text = GetComponent<Text>();
        GameObject par_char = transform.parent.gameObject;
        charStatus status = par_char.GetComponent<charStatus>(); 
        hp = status.hp;
        hp_text.text = "HP:"+hp.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
