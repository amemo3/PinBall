using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightnessregulater : MonoBehaviour
{
    // Start is called before the first frame update
    //マテリアルを入れる
    Material mymaterial;

    //Emissionの最小値
    private float minEmission = 0.2f;
    //Emissionの強度
    private float magEmission = 2.0f;
    //角度
    private int degree = 0;
    //発光速度
    private int speed = 5;
    //ターゲットのデフォルトの色
    Color defaultcolor = Color.white;

    void Start()
    {
        //タグによって光らせる色を変える
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
        //オブジェクトにアタッチしているマテリアルを習得
        this.mymaterial = GetComponent<Renderer>().material;
        //オブジェクトの最初の色を設定
        mymaterial.SetColor("_EmissionColor", this.defaultcolor * minEmission);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.degree>=0)
        {
            //光らせる強度を設定する
            Color emissionColor = this.defaultcolor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            //Emissionに色を設定する
            mymaterial.SetColor("_EmissionColor", emissionColor);
            //角度を小さくする
            this.degree -= this.speed;
        }
    }
    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //角度を180に設定
        this.degree = 180;
    }
}
