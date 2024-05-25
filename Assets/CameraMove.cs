using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float MoveSens = 100f;
    public Transform PlayerBody;

    float xRotation = 0f;
    float yRotation = 0f;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseInput = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        transform.Rotate(mouseInput * MoveSens * Time.deltaTime * 50);
        Vector3 EulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(EulerRotation.x, EulerRotation.y, 0f);
        //Vector2.
    }
}
