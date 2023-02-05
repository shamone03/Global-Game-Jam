using UnityEngine;
using UnityEngine.UIElements;

public class BridgeCreator : MonoBehaviour {
    [SerializeField] private GameObject root;
    private Ray mouseRay;
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out RaycastHit hit, 1000, 3)) {
                Debug.Log("island");
                GameObject rootObject = Instantiate(root, transform.position, Quaternion.identity);
                rootObject.GetComponent<Bridge>().SetIsland(hit.point);
            }
        }
    }
}
