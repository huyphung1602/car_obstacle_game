using UnityEngine;

public class FrontWheelRotate : MonoBehaviour
{
    public bool turnUp = true;
    public bool turnDown = true;
    public PlayerMovement playerMovement;

    void FixedUpdate()
    {
        if (transform.eulerAngles.y > 30f && transform.eulerAngles.y < 180f)
        {
            turnUp = false;
        } else {
            turnUp = true;
        }

        if (transform.eulerAngles.y < 330f && transform.eulerAngles.y > 31f)
        {
            turnDown = false;
        } else {
            turnDown = true;
        }
        if ( Input.GetKey("d") && turnUp && FindObjectOfType<PlayerMovement>().enabled)
        {
            transform.Rotate(Vector3.up * 100f * Time.deltaTime);
        }
        if ( Input.GetKey("a") && turnDown && FindObjectOfType<PlayerMovement>().enabled)
        {
            transform.Rotate(Vector3.down * 100f * Time.deltaTime);
        }
    }
}
