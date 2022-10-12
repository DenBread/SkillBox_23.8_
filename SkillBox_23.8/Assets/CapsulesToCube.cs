using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CapsulesToCube : Capsule
{
    public float time;
    public Transform cube;
    private void Start()
    {
        transform.DOScale(Vector3.zero, time).SetDelay(2f).OnStepComplete(CreatCube);
    }

    private void CreatCube()
    {
        var gm = Instantiate(cube, transform.parent);
        gm.transform.position = transform.position;
        gm.DOScale(Vector3.zero, 2f).From();
    }
}
