using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3.5f;
    [SerializeField]
    private float minbound_X = -71f, maxbound_X = 71f, minbound_Y = -3.3f, maxbound_Y = 0f;
    private Vector3 tempPos;
    private float xAxis, yAxis;

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
    void HandleMovement()
    {
        xAxis = Input.GetAxisRaw(TagManager.HORIZONTAL_AXIS);
        yAxis = Input.GetAxisRaw(TagManager.VERTICAL_AXIS);

        tempPos = transform.position;

        tempPos.x += xAxis * moveSpeed * Time.deltaTime;
        tempPos.y += yAxis * moveSpeed * Time.deltaTime;
        if (tempPos.x < minbound_X)
            tempPos.x = minbound_X;
        if (tempPos.x > maxbound_X)
            tempPos.x = maxbound_X;
        if (tempPos.y < minbound_Y)
            tempPos.y = minbound_Y;
        if (tempPos.y > maxbound_Y)
            tempPos.y = maxbound_Y;
        transform.position = tempPos;
    }
}
