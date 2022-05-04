using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinPicture : MonoBehaviour
{

    public GameObject ARObjects;
    public GameObject ARObjectHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveAndResizePumpkin() {
        ARObjectHolder.transform.localScale = new Vector3(.4f, .4f, 1);
        //ARObjects.transform.position = new Vector3(.24f, -.475f, 0); 
        ARObjects.transform.position = new Vector3(540.1295776367188f, 1163.4705810546875f, 337.5f); 
        //UnityEditor.TransformWorldPlacementJSON:{ "position":{ "x":540.1295776367188,"y":1163.4705810546875,"z":337.5},"rotation":{ "x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{ "x":1.0,"y":1.0,"z":1.0} }
        //Vector3(0.239999995, -0.474999994, 0)
    }
}
