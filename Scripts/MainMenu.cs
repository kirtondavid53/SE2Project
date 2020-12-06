using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Main;
    public GameObject Create;
    public GameObject OptionMenu;

    // Start is called before the first frame update
    void Start()
    {
        Main.gameObject.SetActive(true);
        Create.gameObject.SetActive(false);
        OptionMenu.gameObject.SetActive(false);
    }

    public void OpenStart()
    {
        Main.gameObject.SetActive(false);
        Create.gameObject.SetActive(true);
    }

    
    public void OpenOptions()
    {
        Main.gameObject.SetActive(false);
        OptionMenu.gameObject.SetActive(true);
    }

    public void BackStart()
    {
        Main.gameObject.SetActive(true);
        Create.gameObject.SetActive(false);
    }

    public void BackOptions()
    {
        Main.gameObject.SetActive(true);
        OptionMenu.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    //Gives a selection of saved scenes that you can pick from to load up
    //or just loads one saved scene
    public void LoadGame(){

    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
