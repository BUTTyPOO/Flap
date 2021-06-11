using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;

    void Start()
    {
        txt ??= GameObject.Find("ScoreTxt").GetComponent<TextMeshProUGUI>();
    }

    int score = 0;
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("ScoreTrigger"))
        {
            ++score;
            UpdateTxt();
        }
    }

    void UpdateTxt()
    {
        txt.text = (score).ToString();
        txt.transform.DOComplete(false);
        txt.transform.DOPunchScale(txt.transform.localScale * 1.3f, 0.4f, 10, 0);
    }
}
