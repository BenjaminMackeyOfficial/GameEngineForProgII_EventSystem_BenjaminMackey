using UnityEngine;

public class PressSpaceToSendEvent : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Dance();  
            Destroy(this); 
        } 
    }


    private void Dance()
    {
        EventBus.RequestEvent("Dance!", true).Invoke(); // <-- Invoking an event!
    }
}
