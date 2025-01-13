using UnityEngine;

namespace Player.Scripts
{
    public class MovementController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Rigidbody playerRigidbody;

        [Header("Utils")]
        private float _hInput;
        private float _vInput;

        private void Update()
        {
            GetInput();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void GetInput()
        {
            _hInput = Input.GetAxisRaw("Horizontal");
            _vInput = Input.GetAxisRaw("Vertical");
        }

        private void Move()
        {
        }
    }
}