using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EmemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;
    float delta;
    float span;

    void Start()
    {
        delta = 0;
        span = 1f;
    }


    void Update()
    {
        //経過時間を加算
        delta += Time.deltaTime;

        if (delta > span)
        { 
         // 敵を生成する
        GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            //時間経過を保存している変数を０クリアにする
            delta = 0;

            //敵を出す間隔を徐々に短くする
            span -= (span >= 0.5f) ? 0.01f : 0f; 
        }
       

    }
}
