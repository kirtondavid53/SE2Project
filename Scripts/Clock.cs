using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clock : MonoBehaviour
{
    public Text textClock;
    public Material morning;
    public Material lunchtime;
    public Material nighttime;

    void Awake (){
        DateTime date = DateTime.Now;
        string hour = date.Hour.ToString();
        string minute = date.Minute.ToString();
        string second = date.Second.ToString();
        textClock.text = hour + ":" + minute + ":" + second;
        getSkyBox(hour);
    }

    void getSkyBox(String hour){
        if(hour == "6"){
            RenderSettings.skybox = morning;
        }
        if(hour == "12"){
            RenderSettings.skybox = lunchtime;
        }
        if(hour =="18"){
            RenderSettings.skybox = nighttime;
        }
    }
    
    void Update (){
        DateTime date = DateTime.Now;
        string hour = date.Hour.ToString();
        string minute = date.Minute.ToString();
        string second = date.Second.ToString();
        textClock.text = hour + ":" + minute + ":" + second;
        //print(textClock);
        getSkyBox(hour);
    }
    
    string LeadingZero (int n){
        return n.ToString().PadLeft(2, '0');
    }
}
