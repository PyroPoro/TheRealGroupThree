using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensativity = 100f;
    public Transform playerBody;
    private float xRot = 0f;
    private float yRot = 0f;
    public float lookRange;
    void Start()
    {
        playerBody = GameObject.Find("Player").GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensativity * Time.deltaTime;
        xRot -= mouseY;
        yRot += mouseX;
        xRot = Mathf.Clamp(xRot, -lookRange, lookRange);
        yRot = Mathf.Clamp(yRot, -lookRange, lookRange);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.transform.localRotation = Quaternion.Euler(0f, yRot, 0f);
    }
}
