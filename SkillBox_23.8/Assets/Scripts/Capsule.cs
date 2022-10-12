using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Capsule : MonoBehaviour
{
    public Vector3 vectorMove;
    public Vector3 vectorRot;
    public Ease ease;
    [SerializeField] internal Transform eyeLeft;
    [SerializeField] internal Transform eyeRight;

    public Vector3 rotCapsule;

    private void Start()
    {
        
        Tween tween = transform.DOLocalMove(vectorMove, 1f).SetEase(ease).SetLoops(-1, LoopType.Yoyo).OnStepComplete(()=> Debug.Log("Wow"));
        eyeLeft.DOLocalRotate(vectorRot, 1f).SetEase(ease).SetLoops(-1, LoopType.Yoyo);
        eyeRight.DOLocalRotate(-vectorRot, 1f).SetEase(ease).SetLoops(-1, LoopType.Yoyo);
        transform.DOLocalRotate(rotCapsule, 3f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBack);


    }

    
}
