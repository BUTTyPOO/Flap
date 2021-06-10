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
        pos.x = 8.77f;
        pos.y = Random.Range(1.5f, 6.5f);
        transform.localPosition = pos;
        transform.DOMoveX(-24.5f, 1.6f).SetEase(Ease.Linear).OnComplete(GoBack).SetAutoKill(true);
    }

    void Start()
    {
        transform.DOMoveX(-24.5f, 1.6f).SetEase(Ease.Linear).OnComplete(GoBack).SetAutoKill(true);
    }
}
