using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Pipe"))
<<<<<<< Updated upstream
            print("Player died");
=======
        {
            TextMesh t = GameObject.Find("ScoreText").GetComponent<TextMesh>();
            t.text = "0";
            SceneManager.LoadScene(0);
        }
>>>>>>> Stashed changes
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
