using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        speed = 10f;
    }

    void FixedUpdate()
    {

        transform.Translate(speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, speed * Input.GetAxis("Horizontal") * Time.deltaTime);

    }

}
