using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.left * 500);
    }
}