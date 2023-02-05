using UnityEngine;

public class BridgeCreator : MonoBehaviour {
    [SerializeField] private GameObject root;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.BoxCast(transform.position, transform.localScale * 2, transform.forward, out RaycastHit hit, transform.rotation, 1000)) {
                if (hit.transform.CompareTag("Island")) {
                    Debug.Log("island");
                    
                    GameObject rootObject = Instantiate(root, transform.position + transform.forward + transform.up * -1, Quaternion.identity);
                    rootObject.GetComponent<Bridge>().SetIsland(hit.point);
                }
            }
        }
    }
}
