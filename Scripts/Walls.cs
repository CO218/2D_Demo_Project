using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{

    private Vector2 wallsVert, wallsHori;
    public float borderTop, borderBottom, borderRight, borderLeft;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= borderTop)
        {
            transform.position = new Vector3(transform.position.x, borderTop);
        }
        else if (transform.position.y <= borderBottom)
        {
            transform.position = new Vector3(transform.position.x, borderBottom);
        }
    }
}
