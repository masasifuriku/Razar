using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RazarController : MonoBehaviour
{
    GameObject hand;
    Vector3 startPos;
    void Start()
    {
        Application.targetFrameRate = 60;
        this.hand = GameObject.Find("Hand");
        transform.position = new Vector3(-25.6f, 6.68f, -1.1f);
        startPos = transform.position;
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.04f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.04f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0.04f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, -0.04f, 0);
        }
    }
    void OnTriggerStay(Collider collision)
    {
        // もし衝突した相手オブジェクトのタグが"Stage"ならば
        if (collision.gameObject.tag == "Stage")
        {
            // 衝突した相手オブジェクトを削除する
            transform.position = startPos;
        }
    }
}
