using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTest : MonoBehaviour
{
    public UnityEvent unityEvent;

    Transform _selection;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        unityEvent.Invoke();
    }
}
