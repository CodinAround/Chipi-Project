using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Prompt : MonoBehaviour
{


    [SerializeField] GameObject prompt;
    private float timer = 0.0f;
    private float waitTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        prompt.SetActive(true);
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 5 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime)
        {
            prompt.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } 
        
    }



    // Update is called once per frame
}
