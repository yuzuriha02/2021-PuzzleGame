using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charStatus : MonoBehaviour
{
    public string charName;
    public int hp;
    public int mp;
    public int atackPower;//たたかうコマンドの攻撃力
    public bool defenceSwich=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void defence(bool d){
        if(d){
            defenceSwich = true;
        }
        if(d){
            defenceSwich = false;
        }

    }
}
