using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    // ���E�̐U��
    public float amplitude = 1.0f;

    // ���E�̎����i�b�j
    public float period = 2.0f;

    // �����ʒu
    private Vector3 initialPosition;

    void Start()
    {
        // �����ʒu��ۑ�
        initialPosition = transform.position;
    }

    void Update()
    {
        // ���ԂɊ�Â��č��E�^�����v�Z
        float horizontalMovement = Mathf.Sin(Time.time / period * 2 * Mathf.PI) * amplitude;

        // �V�����ʒu��ݒ�
        transform.position = initialPosition + new Vector3(horizontalMovement, 0f, 0f);
    }
}
