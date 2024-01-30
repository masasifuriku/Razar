using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rotation2 : MonoBehaviour
{

  // Start is called before the first frame update
    // ‰ñ“]‘¬“x
    public float rotationSpeed = 30f;
    void Start()
    {

    }
    void Update()
    {
        // •¨‘Ì‚ğ‰ñ“]‚³‚¹‚é
        // ‘æˆêˆø”‚É‰ñ“]²‚ğw’è‚µA‘æ“ñˆø”‚É‰ñ“]‘¬“x‚ğ‚©‚¯‚Ü‚·
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
