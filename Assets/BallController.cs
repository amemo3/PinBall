using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject Gameovertext;

    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.Gameovertext = GameObject.Find("Gameovertext");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.Gameovertext.GetComponent<Text>().text = "Game Over";
        }
    }
}
