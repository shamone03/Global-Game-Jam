using System;
using PlayerScripts;
using UnityEngine;
using UnityEngine.UIElements;

public class BridgeCreator : MonoBehaviour {
    [SerializeField] private GameObject root;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.BoxCast(transform.position, transform.localScale * 2, transform.forward, out RaycastHit hit, transform.rotation, 1000)) {
                if (hit.transform.CompareTag("Island")) {
                    Debug.Log("island");
                    GameObject rootObject = Instantiate(root, transform.position, Quaternion.identity);
                    rootObject.GetComponent<Bridge>().SetIsland(hit.point);
                }
            }
        }
    }
}
