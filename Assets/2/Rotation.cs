using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    // 回転速度
    public float rotationSpeed = 30f;
    void Start()
    {
        
    }
    void Update()
    {
        // 物体を回転させる
        // 第一引数に回転軸を指定し、第二引数に回転速度をかけます
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
