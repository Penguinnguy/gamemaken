using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    // adds time
    float currentTime = 0f;
    float startingTime= 60f;
    [SerializeField] Text countdownText;
void Start()
{
    // pretty self explanatory, makes it so that currenttime is equal to the startingtime
    currentTime = startingTime;
}
void Update()
{
    // starts the countdown
    currentTime -= 1 * Time.deltaTime;
    countdownText.text = currentTime.ToString();
    
    // if the timer hits zero game will close
    if (currentTime <= 0)
    {
        currentTime = 0;
        Application.Quit();
     }
    }
}
