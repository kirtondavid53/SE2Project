using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public GameObject Main;
    public GameObject Create;
    public GameObject OptionMenu;
    public GenerateScene Landscape = new GenerateScene();
    
    public Slider size;
    public Slider gradient;
    public Slider temperature;                          //temperature in Celcius
    public Slider populationdensity;                    //
    public Slider Wind;                                 //speeds in km/hr
    public Dropdown Weather;
    public Dropdown Biome;


    // Start is called before the first frame update
    void Start()
    {
        size = GetComponent<Slider>();
        gradient = GetComponent<Slider>();
        temperature = GetComponent<Slider>();
        populationdensity = GetComponent<Slider>();
        Wind = GetComponent<Slider>();
        Weather = GetComponent<Dropdown>();
        Biome = GetComponent<Dropdown>();
    }

    public void BackStart()
    {
        Main.gameObject.SetActive(true);
        Create.gameObject.SetActive(false);
    }

    public void StartGame(){
        Create.SetActive(false);
        SceneManager.LoadScene("Grassland");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
