using UnityEngine;
using UnityEngine.UIElements;

public class BridgeCreator : MonoBehaviour {
    [SerializeField] private GameObject root;

    [SerializeField] private float length;
    [SerializeField] private float width;
    
    // Start is called before the first frame update
    private void Start() {
        
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            GameObject rootObject = Instantiate(root, this.transform.position, Random.rotation); 
            rootObject.transform.localScale *= length;
        }
    }
}
