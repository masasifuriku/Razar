using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    // 左右の振幅
    public float amplitude = 1.0f;

    // 左右の周期（秒）
    public float period = 2.0f;

    // 初期位置
    private Vector3 initialPosition;

    void Start()
    {
        // 初期位置を保存
        initialPosition = transform.position;
    }

    void Update()
    {
        // 時間に基づいて左右運動を計算
        float horizontalMovement = Mathf.Sin(Time.time / period * 2 * Mathf.PI) * amplitude;

        // 新しい位置を設定
        transform.position = initialPosition + new Vector3(horizontalMovement, 0f, 0f);
    }
}
