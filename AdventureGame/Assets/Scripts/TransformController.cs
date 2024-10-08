using UnityEngine;

public class TransformController : MonoBehaviour
{
    public void Update() 
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;

        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }
}
