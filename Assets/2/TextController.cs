using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    GameObject time;
    public float gametime = 0;
    public static float resultscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        //�t���[�����[�g:60
        Application.targetFrameRate = 60;
        time = GameObject.Find("time");
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[���c�莞��
        gametime += Time.deltaTime;
        //�c�莞�Ԃ�\��(UI)
        time.GetComponent<TextMeshProUGUI>().text = "time:" + gametime.ToString("F0");
    }
}
