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
        //�o�ߎ��Ԃ����Z
        delta += Time.deltaTime;

        if (delta > span)
        { 
         // �G�𐶐�����
        GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            //���Ԍo�߂�ۑ����Ă���ϐ����O�N���A�ɂ���
            delta = 0;

            //�G���o���Ԋu�����X�ɒZ������
            span -= (span >= 0.5f) ? 0.01f : 0f; 
        }
       

    }
}
