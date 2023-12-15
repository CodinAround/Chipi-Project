using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private GameObject main;
    [SerializeField] private GameObject credits;
    [SerializeField] private GameObject setting;


    public Button playButton;
    public Button settingsButton;
    public Button creditsButton;
    public Button exitButton;
    public Button backButton;
    public Button backButton2;

    private void Awake()
    {
        try
        {
            playButton.onClick.AddListener(PlayButtonClicked);
            settingsButton.onClick.AddListener(SettingsButtonClicked);
            creditsButton.onClick.AddListener(CreditsButtonClicked);
            exitButton.onClick.AddListener(ExitButtonClicked);
            backButton.onClick.AddListener(BackButtonClicked);
            backButton2.onClick.AddListener(BackButtonClicked);
        }
        catch(System.NullReferenceException e)
        {
            Debug.LogError(e.Message);
        }
    }

    private void PlayButtonClicked()
    {
        // Load the game scene
        SceneManager.LoadScene("Playfield");
    }

    private void SettingsButtonClicked()
    {
        main.SetActive(false);
        setting.SetActive(true);
        credits.SetActive(false);

        Debug.Log("Settings button clicked");
    }

    private void CreditsButtonClicked()
    {
       main.SetActive(false);
       setting.SetActive(false);
       credits.SetActive(true);

        

        // Implement credits functionality here
        Debug.Log("Credits button clicked");
    }

    private void ExitButtonClicked()
    {
        // Exit the application (works in standalone builds)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    private void BackButtonClicked()
    {
        main.SetActive(true);
        setting.SetActive(false);
        credits.SetActive(false);

        Debug.Log("Back button clicked");
    }
}
