using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; //距離を表示するUI-Textオブジェクトを保存する変数
    int kyori;              //距離を保存する変数

    public Image Timegauge; //タイムゲージを表示するUI-Image

    float lastTime;         //残り時間

    void Start()
    {
        kyori = 0;
        lastTime = 100f;   //残り100秒
    }

    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;
        Timegauge.fillAmount = lastTime / 100f;

        //進んだ距離を表示
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}