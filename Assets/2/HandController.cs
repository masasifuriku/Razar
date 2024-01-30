using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    GameObject razar;
    void Start()
    {
        this.razar = GameObject.Find("Razar");
        transform.position = new Vector3(-25.60f, 6.708f, -5.87f);
    }
    void Update()
    {
        Vector3 handPos = this.razar.transform.position;
        transform.position = new Vector3(handPos.x + (0.1f), handPos.y + (0.07f), transform.position.z);
    }
}
