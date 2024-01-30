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
        transform.position = new Vector3(-25.6f, 6.68f, -1.1f);
    }
    void Update()
    {
        Vector3 handPos = this.hand.transform.position;
        transform.position = new Vector3(handPos.x + 0.2f, handPos.y + 0.2f, transform.position.z);
    }
    void OnTriggerStay(Collider collision)
    {
        // �����Փ˂�������I�u�W�F�N�g�̃^�O��"Stage"�Ȃ��
        if (collision.gameObject.tag == "Stage")
        {
            // �Փ˂�������I�u�W�F�N�g���폜����
            Destroy(collision.gameObject);
        }
    }
}
