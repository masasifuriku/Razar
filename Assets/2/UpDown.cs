using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    // 上下の振幅
    public float amplitude = 1.0f;

    // 上下の周期（秒）
    public float period = 2.0f;

    // 初期位置
    private Vector3 initialPosition;

    void Start()
    {
        // 初期位置を保存
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 時間に基づいて上下運動を計算
        float verticalMovement = Mathf.Sin(Time.time / period * 2 * Mathf.PI) * amplitude;

        // 新しい位置を設定
        transform.position = initialPosition + new Vector3(0f, verticalMovement, 0f);
    }
}
