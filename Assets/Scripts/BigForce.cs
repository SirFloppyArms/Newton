using UnityEngine;

public class BigForce : MonoBehaviour
{
    public Vector3 force = new Vector3(100f, 0f, 0f);

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(force);
    }
}
