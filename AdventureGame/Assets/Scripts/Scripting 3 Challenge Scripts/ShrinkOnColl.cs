using UnityEngine;

public class ShrinkOnColl : MonoBehaviour
{
    public float shrinkFactor = 0.9f;

    void OnCollisionEnter(Collision collision)
    {
        // Scale the obect down when it collides with another object
        transform.localScale *= shrinkFactor;
    }
}
