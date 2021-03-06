﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public GameObject ThrowDir;
    public float throwForce = 10f;
    public GameObject grenadeT;
    public float delay;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Throw();
        }
    }

    public void Throw()
    {
        GameObject grenadeGamoObject = Instantiate(grenadeT, ThrowDir.transform.position, ThrowDir.transform.rotation);
        Rigidbody rb = grenadeGamoObject.GetComponent<Rigidbody>();
        rb.AddForce(ThrowDir.transform.up.normalized * throwForce);
        grenadeGamoObject.GetComponent<GrenadeScript>().delay = delay;
    }
}
