using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject _playerBody;
    [SerializeField] private GameObject _mainCamera;

    void Update ()
    {
        _mainCamera.transform.eulerAngles = new Vector3(90, 0, 0);
        _mainCamera.transform.position = new Vector3(_playerBody.transform.position.x, 1, _playerBody.transform.position.z);
    }
}
