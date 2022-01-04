using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// See also: https://www.youtube.com/watch?v=c6NXkZWXHnc

public class DisplayWebCam : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.RawImage _rawImage;

    public TextMeshProUGUI textField;

    void Start()
    {
        if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {

            WebCamDevice[] devices = WebCamTexture.devices;
            textField.text = "";

            // for debugging purposes, prints available devices to the console
            for (int i = 0; i < devices.Length; i++)
            {
                print("Webcam available: i = " + i + ": " + devices[i].name);
                textField.text = textField.text + "i = " + i + ": " + devices[i].name + "\n";
            }

            WebCamTexture tex = new WebCamTexture(devices[2].name);

            RawImage m_RawImage;
            m_RawImage = GetComponent<RawImage>();
            m_RawImage.texture = tex;
            tex.Play();
        }
    }
}