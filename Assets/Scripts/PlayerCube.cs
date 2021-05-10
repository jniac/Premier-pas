using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{
    public bool isControlled = false;
    public float speed = 2f;
    public float jumpSpeed = 20f;

    Rigidbody body;

    void UpdateControlChild() {
        Transform child = transform.Find("Control");
        if (child != null) {
            child.gameObject.SetActive(isControlled);
        } else {
            Debug.LogWarning("Hey, mon gars, ma fille, tu as oublié de nommer un enfant \"Control\"");
        }
    }

    void Move() {
        float x = speed * Input.GetAxis("Horizontal");
        float y = body.velocity.y;
        float z = speed * Input.GetAxis("Vertical");
    
        if (Input.GetKeyDown(KeyCode.Space)) {
            y = jumpSpeed;
        }

        body.velocity = new Vector3(x, y, z);
    }

    void Start() {
        body = GetComponent<Rigidbody>();
        UpdateControlChild();
    }

    void Update() {
        if (isControlled == true) {
            Move();
        }
    }

    void OnMouseDown() {
        isControlled = !isControlled;
        UpdateControlChild();
    }

//     bool isQuitting = false;
//     void OnApplicationQuit() {
//         isQuitting = true;
//     }

//     void OnDestroy() {
//         if (isQuitting == false) {
//             Debug.Log($"self? {Camera.main.GetComponent<LookAt>().target == transform}");    
//         }
//     }
}
