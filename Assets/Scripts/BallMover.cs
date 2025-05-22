using UnityEngine;

public class BallMover : MonoBehaviour
{
    public Vector3 velocity = new Vector3(2f, 0f, 0f);

    void Start()
    {
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
