using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RazarController : MonoBehaviour
{
    GameObject hand;
    void Start()
    {
        this.hand = GameObject.Find("Hand");
        transform.position = new Vector3(-2.9f,1.5f, -1.1f);
    }
    void Update()
    {
        Vector3 handPos = this.hand.transform.position;
        transform.position = new Vector3(handPos.x + 0.2f, handPos.y + 0.2f, transform.position.z);
    }
    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトの名前が"Cube"ならば
        if (collision.gameObject.name == "Stage")
        {
            // 衝突した相手オブジェクトを削除する
            Destroy(collision.gameObject);
        }
    }
}
