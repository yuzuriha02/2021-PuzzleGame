using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public int Turn=5;
    Text Turntext;
    Scenemove Gameover;
    // Start is called before the first frame update
    void Start()
    {
        Turntext=GetComponent<Text>();
        Turntext.text="残りターン数:"+Turn;
        Gameover=GetComponent<Scenemove>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextturn(){
        Turn-=1;
        Turntext.text="残りターン数:"+Turn;
        if(Turn == 0)
        {
           Gameover.nextscene("GameOver");
        }
    }
}
