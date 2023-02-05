using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            ButtonPressed();
        }
    }

    public ColorChanger ObjectToActivate;
    public ColorChanger Self;
    public GameObject playerController;
    void ButtonPressed()
    {
        ObjectToActivate.Activate();
        Self.Activate();
    }
}