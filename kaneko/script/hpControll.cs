using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpControll : MonoBehaviour
{
    int hp;
    Text hp_text;//表示HP
    // Start is called before the first frame update
    void Start()
    {
        //初期HPの設定　初期HPは親オブジェクトにcharStatusをインポートし参照
        GameObject par_char = transform.parent.gameObject;
        charStatus status = par_char.GetComponent<charStatus>(); 
        hp = status.hp;
        hp_text = GetComponent<Text>();
        hp_text.text = "HP:"+hp.ToString("000");
    }

    public void Damage(int damage){
        hp = hp - damage;
        if(hp<0){
            hp = 0;
        }
        hp_text.text = "HP:"+hp.ToString("000");
    }
}
