using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isLand : MonoBehaviour
{
    public bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        if (isActive)
        {
            Activate();
        }
        else
        {
            Deactivate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Activate();
            
        }

        if (Input.GetKey(KeyCode.B))
        {
            Deactivate();
        }
    }

    private Material[] material;
    void Activate() 
    {
        material = GetComponent<Renderer>().materials;
        material[1].SetColor("_EmissionColor", Color.blue * Mathf.LinearToGammaSpace(2));
    }

    void Deactivate()
    {
        material = GetComponent<Renderer>().materials;
        material[1].SetColor("_EmissionColor", Color.red * Mathf.LinearToGammaSpace(2));
    }
}
