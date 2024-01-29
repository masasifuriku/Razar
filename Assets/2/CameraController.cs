using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject razar;
    void Start()
    {
        this.razar = GameObject.Find("Razar");
        transform.position = new Vector3(-25.3f,7.0f,-6.5f);
    }
    void Update()
    {
        Vector3 handPos = this.razar.transform.position;
        transform.position = new Vector3(handPos.x + 0.5f, handPos.y + 0.5f, transform.position.z);
        EndGame();
    }
    public void EndGame()
    {
        //�G�X�P�[�v�L�[����������Q�[�����I������
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
            Application.Quit();
#endif
        }

    }
}
