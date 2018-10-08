using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float MovementSpeed = 0;
    private float _xInput;
    private float _zInput;
    public Rigidbody PlayerRigid;
    public Vector3 MousePosition;
    public Transform PlayerTransform;
    public GameObject Bullet;

    void Update () {
        _xInput = Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed;
        _zInput = Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed;
    
        transform.Translate(_xInput, 0, _zInput);
        faceMouse();
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition = new Vector3(mousePosition.x, .15f , mousePosition.z);
        PlayerTransform.LookAt(mousePosition);
    }
}

