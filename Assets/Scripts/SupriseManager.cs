using UnityEngine;

public class SupriseManager : MonoBehaviour
{
    private bool suprised = false;
    private AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventBus.RequestEvent("Suprise", true).ping += Suprise;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Suprise()
    {
        if(suprised)
        {
            transform.position += Vector3.down * 10;
        }
        else
        {
            transform.position += Vector3.up * 10;
            source.Play();
        }
        suprised = !suprised;
    }
}
