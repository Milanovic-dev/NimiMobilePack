using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3DTextLookAt : MonoBehaviour
{
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = cam.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(cam.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
