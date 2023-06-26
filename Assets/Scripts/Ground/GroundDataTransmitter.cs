using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] GroundFallController groundFallController;

    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }
}
