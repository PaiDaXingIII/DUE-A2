using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daima : MonoBehaviour
{
    public GameObject tube;
    [SerializeField] float value;
    [SerializeField] Vector3 sizeChangeValue;
    private Vector3 startPosition;

    public void Start()
    {
        startPosition = new Vector3(tube.transform.position.x, tube.transform.position.y, tube.transform.position.z);
    }

    public void MoveRight()
    {
        tube.transform.position = new Vector3(tube.transform.position.x + value,
            tube.transform.position.y, tube.transform.position.z);
    }

    // youyi
    public void MoveLeft()
    {
        tube.transform.position = new Vector3(tube.transform.position.x - value,
            tube.transform.position.y, tube.transform.position.z);
    }

    public void RotateObject()
    {
        tube.transform.Rotate(0, 20f, 0);
    }

    // Xzhouzhuan
    public void RotateObjectX()
    {
        tube.transform.Rotate(0, -20f, 0);
    }

    public void GrowObject()
    {
        tube.transform.localScale = tube.transform.localScale + sizeChangeValue;
    }

    // suoxiao
    public void ShrinkObject()
    {
        tube.transform.localScale = tube.transform.localScale - sizeChangeValue;
    }

    public void ResetObject()
    {
        tube.transform.position = startPosition;
        tube.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        tube.transform.localScale = Vector3.one;
    }
}