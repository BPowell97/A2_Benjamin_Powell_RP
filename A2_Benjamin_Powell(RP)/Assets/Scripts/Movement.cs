using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    public float speed;

    public Image speedLines;

    public float tweenTime = 0.5f;

    public float barrelRollTime = 0.5f;

    //Material playerMat;

    void Start()
    {
        speed = 10f;
        speedLines.DOFade(0, 0);
        //playerMat = Player.GetComponent<Renderer>().material;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            BarrelRoll(-1);
            SpeedEffect();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            BarrelRoll(1);
            SpeedEffect();
        }

        transform.Translate(speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, speed * Input.GetAxis("Horizontal") * Time.deltaTime);

    }

    void SpeedEffect()
    {
        speedLines.DOFade(0.6f, 0.4f);
        StartCoroutine(FinishBarrelRoll());

        //playerMat.DOFade(0.5f, tweenTime);
    }

    IEnumerator FinishBarrelRoll()
    {
        yield return new WaitForSeconds(barrelRollTime);
        speedLines.DOFade(0, tweenTime);

        //playerMat.DOFade(0.5f, tweenTime);
    }

    private void BarrelRoll(int dir)
    {
        transform.DOMoveX(dir, 1);
        transform.DORotate(new Vector3(0, 0, 360), barrelRollTime, RotateMode.WorldAxisAdd);

    }

}
