using UnityEngine;

public class PushEachOther : MonoBehaviour
{
    public GameObject otherPerson;
    public float pushForce = 300f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Rigidbody rbOther = otherPerson.GetComponent<Rigidbody>();

            Vector3 direction = (otherPerson.transform.position - transform.position).normalized;

            rb.AddForce(-direction * pushForce);
            rbOther.AddForce(direction * pushForce);
        }
    }
}
