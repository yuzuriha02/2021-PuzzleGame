using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyComand : MonoBehaviour
{
    comandValue comandValue;
    hpControll e_hp_c;//敵HP管理スクリプト
    hpControll p_hp_c;//プレイヤーHP管理スクリプト
    mpControll p_mp_c;//プレイヤーMP管理スクリプト
    backLog log_text;//バックログスクリプト
    TurnManager turnmanager;

    // Start is called before the first frame update
    void Start()
    {
        //各コマンドの値
        GameObject comandManager = transform.parent.gameObject;
        comandValue = comandManager.GetComponent<comandValue>();
        //HP管理スクリプトの取得
        GameObject playerHP = GameObject.Find("playerHP");
        p_hp_c = playerHP.GetComponent<hpControll>();
        GameObject enemyHP = GameObject.Find("enemyHP");
        e_hp_c = enemyHP.GetComponent<hpControll>();
        //ログテキストのテキストスクリプト取得
        GameObject logText = GameObject.Find("logText");
        log_text = logText.GetComponent<backLog>();
        GameObject Turn = GameObject.Find("turn");
        turnmanager = Turn.GetComponent<TurnManager>();
    }

    public void Atack(){
        int atackPower = 10;
        string resultlog = "たたかうで攻撃";
        log_text.addtext(resultlog);
        p_hp_c.Damage(atackPower);
        turnmanager.nextturn();
    }
}
