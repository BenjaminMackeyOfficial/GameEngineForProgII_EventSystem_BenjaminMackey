using UnityEngine;

public class MenuOpener : MonoBehaviour
{
    private Canvas canvas;
    private AudioSource audioSource;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        audioSource = GetComponent<AudioSource>();
        EventBus.RequestEvent("ToggleMenu", true).ping += ToggleMenu;
    }

    bool menuOpen = false;
    private void ToggleMenu()
    {
        if(menuOpen)
        {
            canvas.enabled = false;
            Time.timeScale = 1;
        }
        else
        {
            audioSource.Play();
            canvas.enabled = true;
            Time.timeScale = 0; 
        }
        menuOpen = !menuOpen;
    }
}
