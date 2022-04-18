using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnCollision : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("localScale at start is: " + transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ceiling"))
        {
            transform.SetParent(collision.gameObject.transform.parent);
            rb.isKinematic = true;

            Debug.Log("Local Scale after collision is: " + transform.localScale);

        }
    }
}
