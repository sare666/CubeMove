using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public Transform wall;
    public Transform firstposition;
    public Transform secondposition;
    public float wallSpeed;
    Vector3 moveDirection = Vector3.right;
    private void Start()
    {
        wall.position = firstposition.position;
    }
    private void Update()
    {
        wall.position += moveDirection * wallSpeed * Time.deltaTime;
        if (wall.position.x > secondposition.position.x || wall.position.x < firstposition.position.x)
        {
            moveDirection *= -1;
        }
    }

}
