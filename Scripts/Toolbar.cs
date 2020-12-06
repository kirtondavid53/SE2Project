using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Demolish;
    public GameObject Excavate;
    public GameObject Mobilize;
    public GameObject Construction;
    public GameObject Utilities;


    // Start is called before the first frame update
    
    void Start()
    {
        Demolish.gameObject.SetActive(true);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(false);
        Construction.gameObject.SetActive(false);
        Utilities.gameObject.SetActive(false);
    }

    public void OpenDemolish()
    {
        Demolish.gameObject.SetActive(true);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(false);
        Construction.gameObject.SetActive(false);
        Utilities.gameObject.SetActive(false);
    }

    
    public void OpenExcavate()
    {
        Demolish.gameObject.SetActive(true);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(false);
        Construction.gameObject.SetActive(false);
        Utilities.gameObject.SetActive(false);
    }

    public void OpenMobilize()
    {
        Demolish.gameObject.SetActive(false);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(true);
        Construction.gameObject.SetActive(false);
        Utilities.gameObject.SetActive(false);
    }

    public void OpenConstruction()
    {
        Demolish.gameObject.SetActive(false);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(false);
        Construction.gameObject.SetActive(true);
        Utilities.gameObject.SetActive(false);
    }

    public void OpenUtilities()
    {
        Demolish.gameObject.SetActive(false);
        Excavate.gameObject.SetActive(false);
        Mobilize.gameObject.SetActive(false);
        Construction.gameObject.SetActive(false);
        Utilities.gameObject.SetActive(true);
    }

    public void Hammer(){

    }


    public void LeaveGame()
    {
        //This is where we have a save option
        Application.Quit();
    }
    
}
