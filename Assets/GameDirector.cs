using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; //������\������UI-Text�I�u�W�F�N�g��ۑ�����ϐ�
    int kyori;              //������ۑ�����ϐ�

    public Image Timegauge; //�^�C���Q�[�W��\������UI-Image

    float lastTime;         //�c�莞��

    void Start()
    {
        kyori = 0;
        lastTime = 100f;   //�c��100�b
    }

    void Update()
    {
        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        Timegauge.fillAmount = lastTime / 100f;

        //�i�񂾋�����\��
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}