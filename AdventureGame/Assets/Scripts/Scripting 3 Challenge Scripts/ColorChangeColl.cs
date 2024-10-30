using UnityEngine;

public class ColorChangeColl : MonoBehaviour
{
    public Color newColor = Color.red;


    void OnCollisionEnter(Collision collision)
    {
        // Change the objects color on collision with another GameObject.
        GetComponent<Renderer>().material.color = newColor;
    }
}
