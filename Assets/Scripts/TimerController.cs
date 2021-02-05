using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
     public Text timerText;
     private float secondsCount;
     private int minuteCount;
     private int hourCount;
     // Update the timer
     void Update(){
         UpdateTimerUI();
     }

     public void UpdateTimerUI(){
         // Adds a second, minute and hour counter
         secondsCount += Time.deltaTime;
         timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s";
         if(secondsCount >= 60){
             minuteCount++;
             secondsCount = 0;
         }else if(minuteCount >= 60){
             hourCount++;
             minuteCount = 0;
         }    
     }
}
