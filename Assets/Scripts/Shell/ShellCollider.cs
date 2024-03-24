using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellCollider : MonoBehaviour
{
    private float shellSpeed = 1f;



    //[SerializeField] private GameObject pfExplosion;

    private void Start()
    {
        Invoke(nameof(DestoryTheShell), 1f);
    }


    private void DestoryTheShell()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * shellSpeed;

    }
    public void ShellSpped(float shellSpeed)
    {
        this.shellSpeed = shellSpeed;
    }
}
