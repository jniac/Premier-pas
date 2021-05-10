using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myself {
    
    public class Cloner : MonoBehaviour {

        void OnTriggerEnter(Collider other) {

            Instantiate(other.gameObject, other.transform.position + other.transform.right, other.transform.rotation);
        }
        
    }
}
