using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    [Header("Params")]
    [SerializeField] float jumpHeight = 1.65f;
    [SerializeField] float jumpSpeed = 0.15f;

    float gravity = -.01f;
    float MAX_GRAVITY = -20;

    Tweener gravTweener;

    void Start()
    {
        Fall();
        // Application.targetFrameRate = 10;
    }

    void Fall()
    {
        gravTweener?.Kill(false);
        gravTweener = DOVirtual.Float(-.01f, MAX_GRAVITY, .3f, (x) => gravity = x).SetEase(Ease.InSine);
    }

    void Jump()
    {
        transform.DOKill(false);
        transform.DOMoveY(transform.localPosition.y + jumpHeight, jumpSpeed).SetEase(Ease.OutBack);
        Fall();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();

        Vector3 pos = transform.localPosition;
        pos.y += gravity * Time.deltaTime;
        transform.localPosition = pos;

        float rotZ = Mathf.Lerp(40, -75, gravity/-20);

        Vector3 rot = transform.eulerAngles;
        rot.z = rotZ;
        transform.eulerAngles = rot;
    }
}
