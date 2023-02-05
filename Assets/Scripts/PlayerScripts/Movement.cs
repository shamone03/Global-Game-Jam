using System;
using UnityEngine;

namespace PlayerScripts {
    public class Movement : MonoBehaviour {
        // Start is called before the first frame update
        [SerializeField] private CharacterController controller;
        [SerializeField] private float speed;
        [SerializeField] private float downForce;
        private Vector3 move;
        private float horizontal;
        private float vertical;
        private void Update() {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            move = (Vector3.right * horizontal + Vector3.forward * vertical);
            move.y += downForce;
            controller.Move(move * (speed * Time.deltaTime));
        }
    }
}
