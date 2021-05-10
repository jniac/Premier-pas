using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

    public float jumpForce = 40f;

    void OnMouseDown() {
        
        var body = GetComponent<Rigidbody>();
        body.velocity = Vector3.up * jumpForce;
        body.angularVelocity = new Vector3(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360));
    }
}
