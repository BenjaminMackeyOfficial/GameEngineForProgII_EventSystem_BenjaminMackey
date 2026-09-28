using Unity.Mathematics;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private bool dancing = false;
    public InputManager inputs;
    void Update()
    {
        //spins the cube around
        transform.rotation *= quaternion.Euler(new Vector3(inputs.MovmentValue.x * Time.deltaTime,
        inputs.MovmentValue.y* Time.deltaTime,
        inputs.MovmentValue.y* Time.deltaTime));
    }
}
