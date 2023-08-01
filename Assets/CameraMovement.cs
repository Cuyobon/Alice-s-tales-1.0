using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform tazaTransform;
    [SerializeField] private float xStpPosition;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (tazaTransform.position.x > transform.position.x && transform.position.x < xStpPosition)
        {
            transform.position = new Vector3(tazaTransform.position.x, transform.position.y, transform.position.z);
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}