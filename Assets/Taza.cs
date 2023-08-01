using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Taza : MonoBehaviour
{
    [SerializeField] public int tazas;
    [SerializeField] private float force;
    [SerializeField] private float maxDistance;

    private Camera mainCamera;
    private Rigidbody2D rb;
    private Vector2 startPosition, clampedPosition;
    // Start is called before the first frame update
    void Start()
    {
        tazas = 4;
        mainCamera= Camera.main;
        rb= GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        startPosition=transform.position;
    }

    private void OnMouseDrag()
    {
        SetPosition();
    }

    private void SetPosition()
    {
        Vector2 dragPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        clampedPosition = dragPosition;
        float dragDistance = Vector2.Distance(startPosition, dragPosition);

        if (dragDistance > maxDistance)
        {
            clampedPosition = startPosition + (dragPosition - startPosition).normalized * maxDistance;
        }

        if (dragPosition.x > startPosition.x)
        {
            clampedPosition.x = startPosition.x;
        }
        transform.position = clampedPosition;
    }

    private void OnMouseUp()
    {
        Throw();

    }

    private void Throw()
    {
    //    clip.Play(); 
        rb.isKinematic = false;
        Vector2 throwVector = startPosition - clampedPosition;
        rb.AddForce(throwVector * force);

        float resetTime = 4f;
        Invoke("Reset", resetTime);
    }



    private void Reset()
    {
        transform.position = startPosition;
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
        mainCamera.GetComponent<CameraMovement>().ResetPosition();
        tazas = tazas-1;
    }
    // Update is called once per frame
    void Update()
    {
        
        /*for (int i = 0; i < tazas; i++)
        {
            pajaros[i].sprite = vid_bird;
        }*/
    }
}

