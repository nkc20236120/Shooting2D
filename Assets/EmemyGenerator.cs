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
        //Œo‰ßŽžŠÔ‚ð‰ÁŽZ
        delta += Time.deltaTime;

        if (delta > span)
        { 
         // “G‚ð¶¬‚·‚é
        GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            //ŽžŠÔŒo‰ß‚ð•Û‘¶‚µ‚Ä‚¢‚é•Ï”‚ð‚OƒNƒŠƒA‚É‚·‚é
            delta = 0;

            //“G‚ðo‚·ŠÔŠu‚ð™X‚É’Z‚­‚·‚é
            span -= (span >= 0.5f) ? 0.01f : 0f; 
        }
       

    }
}
