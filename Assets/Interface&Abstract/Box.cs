using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Abstract
{
    [SerializeField] Color color01;
    [SerializeField] Color color02;

    Renderer meshRenderer;
    Material material;

    private void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        material = meshRenderer.material;

        color01 = material.color;
    }


    public override void OnSelect()
    {
        material.color = color02;
    }

    public override void OnDeslect()
    {
        material.color = color01;
    }
}
