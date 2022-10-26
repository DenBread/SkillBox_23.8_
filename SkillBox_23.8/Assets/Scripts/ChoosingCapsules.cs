using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChoosingCapsules : MonoBehaviour
{
    public Vector3 rotateAngle;
    public float time;
    private Tween tween;
    public bool isRight = true;

    private void Update()
    {
        FlippingRight();
        FlippingLeft();
    }

    private void FlippingRight()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && isRight)
        {
            isRight = false;
            tween = transform.DOLocalRotate(rotateAngle, time, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.InOutFlash).OnStepComplete(()=> isRight = true);
            
            
        }
        
    }

    private void FlippingLeft()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && isRight)
        {
            isRight = false;
            tween = transform.DOLocalRotate(-rotateAngle, time, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.InOutFlash).OnStepComplete(() => isRight = true);


        }

    }
}
