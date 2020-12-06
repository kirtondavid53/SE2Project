using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Time.timeScale;

public class GenerateScene : MonoBehaviour
{
    public string biome;
    public string weather;
    public int terrain_size_modifier;
    public int terrain_gradient_modifier;
    public int terrain_population_modifier;
    public int terrain_windspeed_modifier;
    public int terrain_temperature_modifier;

    // Start is called before the first frame update
    void Start()
    {
        biome = "";
        weather = "";
        terrain_size_modifier = 1;
        terrain_gradient_modifier = 0;   
        terrain_population_modifier = 0; 
        terrain_temperature_modifier = 0;
        terrain_windspeed_modifier = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseControl(){
        if (Time.timeScale == 1f){
            //pausePanel.setactive(True);
            Time.timeScale = 0f;
        } else{
            Time.timeScale = 1f;
            //pausePanel.setactive(False);
        }
    }

    public void fastforwardControl(){
        if (Time.timeScale == 1f){
            //pausePanel.setactive(True);
            Time.timeScale = 5f;
        } else{
            Time.timeScale = 1f;
            //pausePanel.setactive(False);
        }
    }

    public void slowControl(){
        if (Time.timeScale == 1f){
            //pausePanel.setactive(True);
            Time.timeScale = 0.5f;
        } else{
            Time.timeScale = 1f;
            //pausePanel.setactive(False);
        }
    }
}
