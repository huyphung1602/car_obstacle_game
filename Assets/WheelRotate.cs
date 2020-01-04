using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    public Rigidbody PlayerRb;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.right * PlayerRb.velocity.magnitude * 300f * Time.deltaTime);
    }
}
