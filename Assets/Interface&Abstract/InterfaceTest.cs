using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTest : MonoBehaviour
{
    Renderer meshRenderer;

    Transform _selection;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (_selection != null)
        {
            var selectionAbstract = _selection.GetComponent<Abstract>();

            if (selectionAbstract != null)
            {
                selectionAbstract.OnDeslect();
            }
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        _selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag("Box"))
            {
                _selection = selection;
            }
        }

        if (_selection != null)
        {
            var selectionAbstract = _selection.GetComponent<Abstract>();

            if (selectionAbstract != null)
            {
                selectionAbstract.OnSelect();
            }

            var selectionInterface = _selection.GetComponent<Interface>();

            if (selectionInterface != null)
            {
                selectionInterface.Moving();
            }
        }

    }
}
