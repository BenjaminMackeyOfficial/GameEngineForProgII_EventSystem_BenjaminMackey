using Unity.Mathematics;
using UnityEngine;

public class VibrateScript : MonoBehaviour
{
    public InputManager inputs;
    void Update()
    {
        //makes the cube go left and right
        transform.position = new Vector3(transform.position.x + inputs.MovmentValue.x * Time.deltaTime, transform.position.y + inputs.MovmentValue.y * Time.deltaTime,0);
    }
}
