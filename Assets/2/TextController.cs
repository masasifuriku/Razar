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
        //フレームレート:60
        Application.targetFrameRate = 60;
        time = GameObject.Find("time");
    }

    // Update is called once per frame
    void Update()
    {
        //ゲーム残り時間
        gametime += Time.deltaTime;
        //残り時間を表示(UI)
        time.GetComponent<TextMeshProUGUI>().text = "time:" + gametime.ToString("F0");
    }
}
