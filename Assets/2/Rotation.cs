using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    // ��]���x
    public float rotationSpeed = 30f;
    void Start()
    {
        
    }
    void Update()
    {
        // ���̂���]������
        // �������ɉ�]�����w�肵�A�������ɉ�]���x�������܂�
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
