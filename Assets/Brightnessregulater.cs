using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightnessregulater : MonoBehaviour
{
    // Start is called before the first frame update
    //�}�e���A��������
    Material mymaterial;

    //Emission�̍ŏ��l
    private float minEmission = 0.2f;
    //Emission�̋��x
    private float magEmission = 2.0f;
    //�p�x
    private int degree = 0;
    //�������x
    private int speed = 5;
    //�^�[�Q�b�g�̃f�t�H���g�̐F
    Color defaultcolor = Color.white;

    void Start()
    {
        //�^�O�ɂ���Č��点��F��ς���
        if (tag == "SmallStarTag")
        {
            this.defaultcolor = Color.white;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultcolor = Color.yellow;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultcolor = Color.cyan;
        }
        //�I�u�W�F�N�g�ɃA�^�b�`���Ă���}�e���A�����K��
        this.mymaterial = GetComponent<Renderer>().material;
        //�I�u�W�F�N�g�̍ŏ��̐F��ݒ�
        mymaterial.SetColor("_EmissionColor", this.defaultcolor * minEmission);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.degree>=0)
        {
            //���点�鋭�x��ݒ肷��
            Color emissionColor = this.defaultcolor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            //Emission�ɐF��ݒ肷��
            mymaterial.SetColor("_EmissionColor", emissionColor);
            //�p�x������������
            this.degree -= this.speed;
        }
    }
    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        //�p�x��180�ɐݒ�
        this.degree = 180;
    }
}
