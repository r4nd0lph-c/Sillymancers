using UnityEngine;

namespace Player.Scripts
{
    /// <summary>
    /// Handles the first-person camera movement, allowing for mouse input control
    /// to rotate the camera both horizontally and vertically, with sensitivity adjustments.
    /// </summary>
    public class CameraController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Transform cameraTransform;

        [Header("Settings")]
        public float xSensitivity = 150f;
        public float ySensitivity = 150f;

        [Header("Utils")]
        private float _xRotation;
        private float _yRotation;
        private float _xInput;
        private float _yInput;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            GetInput();
            Rotate();
        }

        private void GetInput()
        {
            _xInput = Input.GetAxis("Mouse X") * Time.deltaTime * xSensitivity;
            _yInput = Input.GetAxis("Mouse Y") * Time.deltaTime * ySensitivity;
        }

        private void Rotate()
        {
            _yRotation += _xInput;
            _xRotation = Mathf.Clamp(_xRotation - _yInput, -90f, 90f);
            cameraTransform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
            transform.rotation = Quaternion.Euler(0f, _yRotation, 0f);
        }
    }
}