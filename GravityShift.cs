using UnityEngine;

public class GravityShift : MonoBehaviour
{
    public static void ToggleGravity(Rigidbody rb)
    {
        rb.useGravity = !rb.useGravity;
        rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y, rb.velocity.z);
        Physics.gravity = new Vector3(0, Physics.gravity.y * -1, 0);
    }
}
