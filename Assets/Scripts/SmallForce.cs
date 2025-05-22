using UnityEngine;

public class SmallForce : MonoBehaviour
{
    public Vector3 force = new Vector3(50f, 0f, 0f);

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(force);
    }
}
