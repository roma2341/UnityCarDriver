using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float carSpeed = 2f;
    Rigidbody2D rd;
    BoxCollider2D collider;
    Camera camera;

    public float heroX;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        Vector2 carMove = new Vector2(carSpeed * direction, 0);
        rd.velocity = carMove;


        var cameraBoundingRect = camera.OrthographicBounds();

        float minX = cameraBoundingRect.min.x + collider.size.x / 2;
        float maxX = cameraBoundingRect.max.x - collider.size.x / 2;

        //Debug.Log( String.Format("minX {0}, max{0}",minX,maxX));

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, minX, maxX);
        heroX = pos.x;

        transform.position = pos;
    }
}
