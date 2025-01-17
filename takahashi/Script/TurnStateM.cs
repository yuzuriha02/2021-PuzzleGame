using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnStateMachine : MonoBehaviour
{
    public Pokemon myPokemon;
    public Pokemon enemyPokemon;

    List<Pokemon> SortedPokemons = new List<Pokemon> ();

    /* ターン終了時の処理に関わる部分以外は割愛 ステートマシンで制御します*/

    void StartTurnEndProcessing()
    {
        //コルーチンを開始
        StartCoroutine(TurnEndProcessing());
    }

    //コルーチン処理
    IEnumerator TurnEndProcessing ()
    {
        //1.勝敗判定
        if (CheckAlive()) {
            yield break;
        }

        //2.同速チェックと並び替え
        bool isSame = Sort ();

        //3.天候解除
        if (WeatherProcessing ()) {
            yield return new WaitForSeconds (1f);
        }

        /* 中略 */

        //4.素早さが同じ場合は順番をシャッフルする
        Shuffle (isSame);

        //5.毒ダメージ
        foreach (var item in SortedUnits) {
            if (PoizonProcessing (item)) {
                yield return new WaitForSeconds (0.5f);
            }
        }

        /* 中略 */

        //6.勝敗判定
        if (CheckAlive()) {
            yield break;
        }

        //7.交代の有無を確認
        if(CheckChange()){
            //交代の処理
            CharacterChange();
        } else {
            //ターン開始に移る処理
            TurnStart();
        }
    }

    bool Sort ()
    {
        //myPokemonとenemyPokemonの素早さを比較
        //素早さが高い順にSortedPokemonsにAddする
        //素早さが同じ場合はtrue,それ以外はfalseを返す
    }

    void Shuffle (bool isSame)
    {
        //素早さが同じ場合は順番のシャッフルを行う
        //素早さが同じでない場合は何もしない
    }

    bool WeatherProcessing ()
    {
        //天候解除の有無を判定する
        //天候解除ありの場合はエフェクトやUI表示を更新してtrueを返す
        //それ以外はfalseを返す
    }

    bool PoizonProcessing (Pokemon pokemon)
    {
        //pokemonが瀕死状態ならfalseを返して終了する
        //pokemonが毒状態ならエフェクトと毒ダメージの処理を行う
        //それ以外はfalseを返す
    }

    bool CheckAlive()
    {
        //対戦の勝敗判定を行う
        //勝ちまたは負けの判定が出た場合はtrueを返す
        //それ以外はfalseを返す
    }

    bool CheckChange()
    {
        //交代の有無を判定して交代が必要な場合はtrueを返す
    }

    void CharacterChange()
    {
        //ポケモンの交代の必要があれば交代画面に映る
    }

    void TurnStart()
    {
        //ターン開始時に移る
    }
}