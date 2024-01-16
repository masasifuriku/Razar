using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject hand;
    void Start()
    {
        this.hand = GameObject.Find("Hand");
        transform.position = new Vector3(-2.0f,2.0f,-6.5f);
    }
    void Update()
    {
        Vector3 handPos = this.hand.transform.position;
        transform.position = new Vector3(handPos.x + 0.5f, handPos.y + 0.5f, transform.position.z);
    }
}
