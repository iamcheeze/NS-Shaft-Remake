using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGrabber : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public Sprite ogSprite;
    public Sprite newSprite;

    void OnMouseDown()
    {
        //when you grab it, set the circle equare to the mouse position
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        //"turns off" physics for the circle
        rb.isKinematic = true;
        //changes sprite
        sr.sprite = newSprite;
    }

    private void OnMouseUp()
    {
        //when you let go, return to normal
        rb.isKinematic = false;
        sr.sprite = ogSprite;
    }

    void OnMouseDrag()
    {
        //while dragging it around, set the circle equare to the mouse position
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        //"turns off" physics for the circle
        rb.isKinematic = true;
        //changes sprite
        sr.sprite = newSprite;
    }
}
