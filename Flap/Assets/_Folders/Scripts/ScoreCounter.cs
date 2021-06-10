using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            score++;
            print(score);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
