using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject prompt;


    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("Plane collied with wall");
        }
        else
        {
            Debug.Log("Plane collied with something");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = false;
        }
    }

    /*void OnTriggerEnter(Collider other) //Make sure to put this out of Voids
    {
        if (other.gameObject.tag == "Object")
        {
            Debug.Log("Collided");
        }
    }
    */

    void Update()
    {

        if (triggered)
        {
            //Do something!
            prompt.SetActive(true);
        }
        else if (!triggered)
        {
            prompt.SetActive(false);
        }
    }

}
