using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Vector3 dir = Vector3.zero;
    public GameObject MyShot_Pre;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float speed = 9;

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        // 画面内移動制限
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        // アニメーション設定
        if (dir.y == 0)
        {
            // アニメーションクリップ【Player】を再生
            anim.Play("Player");
        }
        else if (dir.y == 1)
        {
            anim.Play("PlayerL");
        }
        else if (dir.y == -1)
        {
            anim.Play("PlayerR");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject MyShot_0 =
                Instantiate(MyShot_Pre);
            MyShot_0.transform.position = pos;
        }

    }

    
}
