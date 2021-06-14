using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerComand : MonoBehaviour
{
    charStatus status;//プレイヤーステータススクリプト
    hpControll e_hp_c;//敵HP管理スクリプト
    hpControll p_hp_c;//プレイヤーHP管理スクリプト
    mpControll p_mp_c;//プレイヤーMP管理スクリプト
    backLog log_text;//バックログスクリプト
    int atackPower;//「戦う」の攻撃力
    
    // Start is called before the first frame update
    void Start()
    {
        //敵HP管理スクリプトの取得
        GameObject enemyHP = GameObject.Find("enemyHP");
        e_hp_c = enemyHP.GetComponent<hpControll>();
        //プレイヤー関係
        //攻撃力
        GameObject player = GameObject.Find("player_status");
        status = player.GetComponent<charStatus>();
        atackPower = status.atackPower;
        //HP
        GameObject playerHP = GameObject.Find("playerHP");
        p_hp_c = playerHP.GetComponent<hpControll>();
        //MP
        GameObject playerMP = GameObject.Find("playerMP");
        p_mp_c = playerMP.GetComponent<mpControll>();
        //ログテキストのテキストスクリプト取得
        GameObject logText = GameObject.Find("logText");
        log_text = logText.GetComponent<backLog>();
    }

    //たたかう
    public void Atack(){
        string resultlog = "たたかうで攻撃";
        log_text.addtext(resultlog);
        e_hp_c.Damage(atackPower);
    }
    //防御
    public void block(){
        status.defence(true);
        string resultlog = "防御した";
        log_text.addtext(resultlog);
    }
    //ヒール
    public void heal(){
        int mp_cost = 10;//消費MP
        int recovery_point = 20;//回復量
        //MP消費，足りなければ実行しない
        if(p_mp_c.mpConsumption(mp_cost)){
            p_hp_c.Recovery(recovery_point);
            string resultlog = "HPを"+recovery_point+"回復した";
            log_text.addtext(resultlog);
        }
        else{
            string resultlog = "MPが足りません";
            log_text.addtext(resultlog);
        }
    }
    //ファイア
    public void fire(){
        int mp_cost = 15;//消費MP
        int damage = 30;//ダメージ
        if(p_mp_c.mpConsumption(mp_cost)){
            string resultlog = "ファイアで攻撃";
            log_text.addtext(resultlog);
            e_hp_c.Damage(damage);
        }
        else{
            string resultlog = "MPが足りません";
            log_text.addtext(resultlog);
        }
    }
}
