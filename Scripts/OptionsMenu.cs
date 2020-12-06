using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject Main;
    public GameObject Create;
    public GameObject OptionMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BackOptions()
    {
        Main.gameObject.SetActive(true);
        OptionMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
