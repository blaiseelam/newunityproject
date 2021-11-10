using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 3.0f;
    float rotation = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.forward);
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));
    }
}
