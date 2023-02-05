using System;
using Unity.Mathematics;
using UnityEngine;

namespace PlayerScripts {
    public class MouseAim : MonoBehaviour {
        [SerializeField] private GameObject gun;
        [SerializeField] private Vector3 mousePosition;
        [SerializeField] private Vector3 mouseScreenPosition;
        [SerializeField] private Vector3 targetPos;
        private Ray mouseRay;
        private Vector3 target;
        private float mid;

        

        private void Update() {
            
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, Mathf.Infinity)) {
                Vector3 target = hitInfo.point;
                Vector3 direction = target - transform.position;
                direction.y = transform.position.y;
                transform.LookAt(direction);
            }
            
            // gun.transform.rotation = Quaternion.Euler(0, (Mathf.Rad2Deg * Mathf.Atan2(mousePosition.y - gun.transform.position.y, mousePosition.x - gun.transform.position.x)), 0);
            // gun.transform.LookAt(mouseScreenPosition, Vector3.right);
        }   
    }
}
