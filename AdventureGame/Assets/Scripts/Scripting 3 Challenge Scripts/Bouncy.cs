using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceforce = 3f;


    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceforce, ForceMode.Impulse);
    }
}