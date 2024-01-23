using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    // �㉺�̐U��
    public float amplitude = 1.0f;

    // �㉺�̎����i�b�j
    public float period = 2.0f;

    // �����ʒu
    private Vector3 initialPosition;

    void Start()
    {
        // �����ʒu��ۑ�
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ���ԂɊ�Â��ď㉺�^�����v�Z
        float verticalMovement = Mathf.Sin(Time.time / period * 2 * Mathf.PI) * amplitude;

        // �V�����ʒu��ݒ�
        transform.position = initialPosition + new Vector3(0f, verticalMovement, 0f);
    }
}
