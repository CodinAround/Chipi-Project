using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIOptionScripts : MonoBehaviour
{
    public Button Button;


    // Start is called before the first frame update
    void Start()
    {
        
        
        Button.onClick.AddListener(ExitOnClick);

    }

    void ExitOnClick()
    {
        Application.Quit();
    }

}
