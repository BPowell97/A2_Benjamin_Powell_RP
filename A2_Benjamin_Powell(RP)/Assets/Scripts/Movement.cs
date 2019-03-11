using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        speed = 10f;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            BarrelRoll(-1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            BarrelRoll(1);
        }

        transform.Translate(speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, speed * Input.GetAxis("Horizontal") * Time.deltaTime);

    }

    private void BarrelRoll(int dir)
    {
        transform.DOMoveX(dir, 1);
        transform.DORotate(new Vector3(0, 0, 360), .5f, RotateMode.WorldAxisAdd);

    }

}
