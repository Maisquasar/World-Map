using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float zoomSpeed = 0.5f;
    [SerializeField] float maxZoom;
    [SerializeField] float minZoom;
    float zoomSize = 5;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

        speed = zoomSize * 2;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (zoomSize > minZoom)
                zoomSize -= zoomSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize < maxZoom)
            zoomSize += zoomSpeed;
        }
        GetComponent<Camera>().orthographicSize = zoomSize;

    }
}
