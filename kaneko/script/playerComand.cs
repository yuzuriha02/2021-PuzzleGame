using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerComand : MonoBehaviour
{
    charStatus status;//ステータス関係スクリプト
    hpControll e_hp_c;//敵HP管理スクリプト
    backLog log_text;
    int atackPower;//戦うの攻撃力
    
    // Start is called before the first frame update
    void Start()
    {
        //敵HP管理スクリプトの取得
        GameObject enemyHP = GameObject.Find("enemyHP");
        e_hp_c = enemyHP.GetComponent<hpControll>();
        //親オブジェクトのcharStatusから攻撃力参照
        GameObject player = GameObject.Find("player_status");
        status = player.GetComponent<charStatus>();
        atackPower = status.atackPower;
        //ログテキストのテキストスクリプト取得
        GameObject logText = GameObject.Find("logText");
        log_text = logText.GetComponent<backLog>();
    }

    public void Atack(){
        e_hp_c.Damage(atackPower);
        string resultlog = "たたかうで敵に"+atackPower+"ダメージを与えた";
        log_text.addtext(resultlog);
    }
}
