using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlayScript : MonoBehaviour
{
    public Button Button;

    // Start is called before the first frame update
    void Start()
    {


        Button.onClick.AddListener(PlayOnClick);

    }

    void PlayOnClick()
    {
        SceneManager.LoadScene("Playfield", LoadSceneMode.Single);
    }

}
