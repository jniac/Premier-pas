using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myself {
    
    public class KillOnClick : MonoBehaviour {

        void OnMouseDown() {
            Destroy(gameObject);
        }


    }
}