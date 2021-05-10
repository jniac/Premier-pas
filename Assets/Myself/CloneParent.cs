using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneParent : MonoBehaviour
{
    void OnMouseDown() {
        var position = transform.parent.position + transform.localPosition.normalized;
        var rotation = Quaternion.identity;
        Instantiate(transform.parent.gameObject, position, rotation, transform.parent.parent);
    }
}
