using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSize : MonoBehaviour
{

    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.orthographicSize != .5f) {
            Camera.orthographicSize = .5f;
        }
    }
}
