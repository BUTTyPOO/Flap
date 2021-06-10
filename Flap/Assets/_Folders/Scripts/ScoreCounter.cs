using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int score = 0;
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("ScoreTrigger"))
        {
            TextMesh t = GameObject.Find("ScoreText").GetComponent<TextMesh>();
            score = int.Parse(t.text);
            t.text = (score + 1).ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
