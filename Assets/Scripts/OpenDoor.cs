using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    Vector3 defaultPosition;
    bool isOpen = false;

    Vector3 relativePosition = Vector3.up * 2;
    [SerializeField]
    float speed = 1;

    void Awake()
    {
        defaultPosition = transform.position;
    }

    void OnMouseDown()
    {
        if (isOpen)
        {
            StartCoroutine(Close());
        }
        else
        {
            StartCoroutine(Open());
        }
        isOpen = !isOpen;
    }

    IEnumerator Open()
    {
        float time = 0;
        while (time < 1)
        {
            time += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(defaultPosition, defaultPosition + relativePosition, time);
            yield return null;
        }
    }

    IEnumerator Close()
    {
        float time = 0;
        while (time < 1)
        {
            time += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(defaultPosition + relativePosition, defaultPosition, time);
            yield return null;
        }
    }
}
