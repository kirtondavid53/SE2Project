using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWaterTank : MonoBehaviour
{
    public GameObject watertank_blueprint;

    public void spawn_watertank_blueprint(){
        Instantiate(watertank_blueprint);
    }
}
