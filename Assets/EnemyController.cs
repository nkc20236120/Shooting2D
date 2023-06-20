using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //ˆÚ“®•ûŒü
    float speed = 5;            //ˆÚ“®‘¬“x

    void Start()
    {
        //õ–½‚S•b
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        //ˆÚ“®•ûŒü‚ğŒˆ’è
        dir = Vector3.left;
        //Œ»İ’n‚ÉˆÚ“®—Ê‚ğ‰ÁZ
        transform.position += dir.normalized * speed * Time.deltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}


