using UnityEngine;

public class ApplyEqualForce : MonoBehaviour
{
    public Vector3 force = new Vector3(100f, 0f, 0f);
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(force);
        }
    }
}
