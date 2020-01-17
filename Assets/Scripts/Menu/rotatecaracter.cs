using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecaracter : MonoBehaviour
{
   


   public float rotationRate = 10f;
    // degrees per second to rotate in each axis. Set in inspector.

    void Start()
    {
        Debug.Log("Game object start");
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, rotationRate * Time.deltaTime);
    }



}
