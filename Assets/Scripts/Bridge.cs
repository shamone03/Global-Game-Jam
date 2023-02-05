
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

using Random = UnityEngine.Random;

public class Bridge : MonoBehaviour {
    private Vector3 destination;
    [SerializeField] private List<MeshRenderer> growVinesMeshes;
    [SerializeField] private float time = 3;
    [SerializeField] private float refreshRate = 0.05f;
    [Range(0, 1)]
    [SerializeField] private float minGrow = 0.2f;
    [Range(0, 1)]
    [SerializeField] private float maxGrow = 0.97f;

    private List<Material> growVinesMaterials = new List<Material>();
    private bool fullyGrown;
    public void SetIsland(Vector3 dest) {
        destination = dest;
        transform.LookAt(destination, transform.up);
        transform.Rotate(Random.rotation.x, 90, 0);
        transform.Rotate(90, 0, Random.rotation.z);
        
        transform.localScale *= -1;

        for (int i = 0; i < growVinesMeshes.Count; i++) {
            for (int j = 0; j < growVinesMeshes[i].materials.Length; j++) {
                if (growVinesMeshes[i].materials[j].HasProperty("Grow_")) {
                    growVinesMeshes[i].materials[j].SetFloat("Grow_", minGrow);
                    growVinesMaterials.Add(growVinesMeshes[i].materials[j]);
                }
            }
        }
        
        
        // transform.rotation = Quaternion.Euler(0, (Mathf.Rad2Deg * Mathf.Atan2(dest.z - transform.position.z, dest.x - transform.position.x)), 0);
    }
    
    private void Update() {
        for (int i = 0; i < growVinesMaterials.Count; i++) {
            StartCoroutine(GrowVines(growVinesMaterials[i]));
        }
    }

    IEnumerator GrowVines(Material mat) {
        float growValue = mat.GetFloat("Grow_");
        if (!fullyGrown) {
            while (growValue < maxGrow) {
                growValue += 1 / (time / refreshRate);
                mat.SetFloat("Grow_", growValue);
                yield return new WaitForSeconds(refreshRate);
            }
        }
        else {
            while (growValue > minGrow) {
                growValue -= 1 / (time / refreshRate);
                mat.SetFloat("Grow_", growValue);
                yield return new WaitForSeconds(refreshRate);
            }
        }

        if (growValue >= maxGrow) {
            fullyGrown = true;
            
        }
        else {
            fullyGrown = false;
        }

    }
}
