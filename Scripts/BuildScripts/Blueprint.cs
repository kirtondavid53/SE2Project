using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprint : MonoBehaviour
{
    RaycastHit hit;
    Vector3 movePoint;
    public GameObject prefab;

    void Start(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 50000.0f,(1 << 8))){
            transform.position = hit.point;
        }

    }

    void update(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 50000.0f, (1 << 8))){
            transform.position = hit.point;
        }

        if (Input.GetMouseButton(0)){
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);
        } 

    }

}
