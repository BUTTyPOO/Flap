using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    float gravity = -.01f;
    float addPerFrame = -.01f;
    void Fall()
    {
        Vector3 pos = transform.localPosition;
        if(gravity <= -6f)
            gravity = -6f;
        else
            gravity += addPerFrame;
            addPerFrame -= .0005f;
        pos.y += gravity * Time.deltaTime;
        transform.localPosition = pos;
    }

    void Jump()
    {
        transform.DOKill(false);
        transform.DOMoveY(transform.localPosition.y + 1.65f, 0.15f).SetEase(Ease.OutBack);
        gravity = -.01f;
        addPerFrame = -.01f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();
        Fall();
    }
}
