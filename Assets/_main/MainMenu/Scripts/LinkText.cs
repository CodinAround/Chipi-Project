using UnityEngine;
using UnityEngine.Events;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LinkText : MonoBehaviour
{

    [SerializeField] Button text;

    private void Awake()
    {
        text = GetComponent<Button>();
        text.onClick.AddListener(OpenLink);

    }
   
    private void OpenLink()
    {
        Application.OpenURL("https://docs.google.com/document/d/1n1R_1XcF0dkDDlCMUyNYjPNv-09TetdgjoM-AOkMQf4/edit?usp=sharing");
    }
}
