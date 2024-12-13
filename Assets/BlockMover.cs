using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    public float speed;
    public float holder;

    // Start is called before the first frame update
    void Start()
    {
        holder = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        holder += speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, holder, 0);
    }
}
