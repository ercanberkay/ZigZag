using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValues()
    {
        yield return new WaitForSeconds(0.25f);
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
