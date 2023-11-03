using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UICamera : MonoBehaviour
{
    public Camera mainCam;
    public Camera optionCam;

    public Button optionButt;

    // Start is called before the first frame update
    void Start()
    {
        
        mainCam = mainCam.GetComponent<Camera>();
        mainCam.enabled = true;
       
        optionCam= optionCam.GetComponent<Camera>();
        optionCam.enabled = false;

        optionButt.onClick.AddListener(OptionOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OptionOnClick()
    {
        optionCam.enabled = true;
    }
}
