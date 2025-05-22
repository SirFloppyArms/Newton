using UnityEngine;

public class RocketThrust : MonoBehaviour
{
    public float thrust = 10f;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * thrust);
    }
}
