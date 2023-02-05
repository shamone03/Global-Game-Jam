using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {
    private Vector3 destination;
    
    public void SetIsland(Vector3 dest) {
        destination = dest;
    }
    
    private void Update() {
        transform.LookAt(destination);
        Debug.Log(destination);
    }
}
