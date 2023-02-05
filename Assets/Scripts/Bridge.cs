
using UnityEngine;
using Random = UnityEngine.Random;

public class Bridge : MonoBehaviour {
    private Vector3 destination;
    
    public void SetIsland(Vector3 dest) {
        destination = dest;
        transform.LookAt(destination, transform.up);
        transform.Rotate(Random.rotation.x, 90, 0);
        
        transform.localScale *= -1;
        // transform.rotation = Quaternion.Euler(0, (Mathf.Rad2Deg * Mathf.Atan2(dest.z - transform.position.z, dest.x - transform.position.x)), 0);
    }
    
    private void Update() {
        Debug.Log(destination);
    }
}
