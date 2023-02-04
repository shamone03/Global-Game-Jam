using System;
using Unity.Mathematics;
using UnityEngine;

namespace PlayerScripts {
    public class MouseAim : MonoBehaviour {
        [SerializeField] private GameObject gun;
        [SerializeField] private Vector3 mousePosition;
        [SerializeField] private Vector3 mouseScreenPosition;
        private Vector3 adjustedRay;
        private void Update() {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float mid = (gun.transform.position - Camera.main.transform.position).magnitude;
            gun.transform.LookAt(mouseRay.origin + mouseRay.direction * mid);
            // gun.transform.rotation = Quaternion.Euler(0, (Mathf.Rad2Deg * Mathf.Atan2(mousePosition.y - gun.transform.position.y, mousePosition.x - gun.transform.position.x)), 0);
            // gun.transform.LookAt(mouseScreenPosition, Vector3.right);
        }
    }
}
