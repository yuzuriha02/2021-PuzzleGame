using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpControll : MonoBehaviour
{
    charStatus status;
    int hp,MAXHP;//最大HP
    Text hp_text;//表示HP
    backLog log_text;//バックログスクリプト

    // Start is called before the first frame update
    void Start()
    {
        //初期HPの設定　初期HPは親オブジェクトにcharStatusをインポートし参照
        GameObject par_char = transform.parent.gameObject;
        status = par_char.GetComponent<charStatus>(); 
        hp = status.hp;
        MAXHP = status.hp;
        hp_text = GetComponent<Text>();
        hp_text.text = "HP:"+hp.ToString("000");
        //バックログ取得
        GameObject logText = GameObject.Find("logText");
        log_text = logText.GetComponent<backLog>();
    }

    public void Damage(int damage){
        if(status.defenceSwich){
            string defence_text = status.charName+"は防御した";
            log_text.addtext(defence_text);
            status.defence(false);
        }
        else{
            hp = hp - damage;
            if(hp<0){
                hp = 0;
            }
            string defence_text = status.charName+"は"+damage+"ダメージを受けた";
            log_text.addtext(defence_text);
            hp_text.text = "HP:"+hp.ToString("000");
        }
    }
    public void Recovery(int recovery){
        hp += recovery;
        if(hp>MAXHP){
            hp = MAXHP;
        }
        hp_text.text = "HP:"+hp.ToString("000");
    }
}
