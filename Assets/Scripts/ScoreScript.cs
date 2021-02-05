using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    // Call the text component
    void Start()
    {
        score = GetComponent<Text> (); 
    }

    // Update is called once per frame
    // Changes the value of the text to "Score + scoreNumber"
    void Update()
    {
        score.text = "Score " + scoreValue;
    }
}
