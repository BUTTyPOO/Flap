using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Pipe"))
            print("Player died");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
