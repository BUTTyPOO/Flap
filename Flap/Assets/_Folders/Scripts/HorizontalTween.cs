using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalTween : MonoBehaviour
{
    // Start is called before the first frame update

    void GoBack()
    {
        Vector3 pos = transform.localPosition;
        pos.x += 22;
        transform.localPosition = pos;
    }
    void Start()
    {
        transform.DOMoveX(transform.localPosition.x - 22, 1.5f).SetEase(Ease.Linear).SetLoops(-1).OnComplete(GoBack);
    }
}
