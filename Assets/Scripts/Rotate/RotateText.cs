using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateText : MonoBehaviour
{

    public float rotationRate = 100f;
    // degrees per second to rotate in each axis. Set in inspector.
    public Vector3 rotation;
    void Start()
    {
        rotation = new Vector3(0f, 0f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation, rotationRate * Time.deltaTime);
    }
}
