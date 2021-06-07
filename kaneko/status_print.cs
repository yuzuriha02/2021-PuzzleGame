using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hp_controll : MonoBehaviour
{
    //テキストオブジェクトにコンポーネントしてHPを表示,管理するスクリプト
    int hp;
    private Text hp_text;//textコンポーネントの取得先
    // Start is called before the first frame update
    void Start()
    {
        hp_text = GetComponent<Text>();//textコンポーネントの取得
        GameObject par_char = transform.parent.gameObject;//親オブジェクトの取得
        charStatus status = par_char.GetComponent<charStatus>(); //親オブジェクトにコンポーネントしてあるcharStatusスクリプトの取得
        hp = status.hp;//charStatusの中のHPの値の取得
        hp_text.text = "HP:"+hp.ToString("000");//HP表示
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
