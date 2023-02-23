using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box02 : Abstract, Interface
{
    [SerializeField] Color color01;
    [SerializeField] Color color02;

    [SerializeField] Vector3 Pos01;
    [SerializeField] Vector3 Pos02;

    Renderer meshRenderer;
    Material material;

    private void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        material = meshRenderer.material;

        color01 = material.color;

        Pos01 = transform.position;
    }

    public override void OnSelect()
    {
        material.color = color02;
    }

    public override void OnDeslect()
    {
        material.color = color01;
    }

    public void Moving()
    {
        if (transform.position == Pos01)
        {
            transform.position = Pos02;

            return;
        }

        transform.position = Pos01;
    }

}
