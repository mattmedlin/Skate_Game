using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateboardAttach : MonoBehaviour
{
    public Transform skateboard;
    public Transform target;
    public float DstFromTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - transform.up * DstFromTarget;
        transform.rotation = target.rotation;
    }
}
