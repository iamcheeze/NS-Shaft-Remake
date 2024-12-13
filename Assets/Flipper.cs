using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public PlayerMovement pM;
    public bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pM.horizontal == 1 && !isFacingRight)
        {
            Flipping();
        }
        else if (pM.horizontal == -1 && isFacingRight)
        {
            Flipping();
        }
    }

    public void Flipping()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
