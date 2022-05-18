using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity;
    [SerializeField] private Vector2 _mouseYLimit;

    private float _horizontal;
    private float _vertical;

    Transform _cameraTransform;

    private void Awake()
    {
        _cameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        #region Inputs
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _horizontal += mouseX;
        _vertical += mouseY;
        #endregion
        _vertical = Mathf.Clamp(_vertical, _mouseYLimit.x, _mouseYLimit.y);

        // le joueur tourne sur l'axe x ducoup et la camera tourne surl'axe y /!\
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _horizontal, transform.eulerAngles.z);
        _cameraTransform.eulerAngles = new Vector3(_vertical, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);
    }
}
