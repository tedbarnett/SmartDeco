using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinPicture : MonoBehaviour
{

    public GameObject ARObjects;
    public GameObject ARObjectHolder;
    public GameObject VideoCube;
    public GameObject toPumpkinButton;
    public GameObject toFaceCastButton;

    // Start is called before the first frame update
    void Start()
    {
        VideoCube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveAndResizePumpkin() {
        VideoCube.SetActive(true);
        toPumpkinButton.SetActive(true);
        toFaceCastButton.SetActive(false);
        ARObjectHolder.transform.localScale = new Vector3(.4f, .4f, 1);
        ARObjects.transform.position = new Vector3(546.1549682617188f, 1137.734375f, 337.5f);
        //ARObjects.transform.position = new Vector3(.24f, -.475f, 0); 
        //UnityEditor.TransformWorldPlacementJSON:{ "position":{ "x":540.1295776367188,"y":1163.4705810546875,"z":337.5},"rotation":{ "x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{ "x":1.0,"y":1.0,"z":1.0} }
        //Vector3(0.239999995, -0.474999994, 0)
        //Vector3(0.266000003,-0.492000014,0)
        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":400.1435546875,"y":861.754150390625,"z":337.5},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":1.0,"y":1.0,"z":1.0}}
        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":546.1549682617188,"y":1137.734375,"z":337.5000305175781},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":1.0,"y":1.0,"z":1.0}}

    }

    public void DisableFaceCast() {
        VideoCube.SetActive(false);
        toPumpkinButton.SetActive(false);
        toFaceCastButton.SetActive(true);
        ARObjectHolder.transform.localScale = new Vector3(1, 1, 1);
        ARObjects.transform.position = new Vector3(546.0f, 1138.0f, 337.5f);
    }
}
