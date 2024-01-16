using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_Camera;
    void Start()
    {
        Application.targetFrameRate = 60;
        m_Camera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(0,0.04f,0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           this.transform.Translate(0, -0.04f, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(-0.04f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.04f, 0, 0);
        }
    }
}
