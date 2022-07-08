using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject Scoretext;
    private int score = 0;

    void Start()
    {
        this.Scoretext = GameObject.Find("Scoretext");
        this.Scoretext.GetComponent<Text>().text = ("Score:" + score);
    }
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.Scoretext.GetComponent<Text>().text = ("Score:" + score);
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.Scoretext.GetComponent<Text>().text = ("Score:" + score);
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
            this.Scoretext.GetComponent<Text>().text = ("Score:" + score);
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
            this.Scoretext.GetComponent<Text>().text = ("Score:" + score);
        }
    }
}
