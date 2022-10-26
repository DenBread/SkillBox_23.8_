using UnityEngine;
using DG.Tweening;

public class ObjRotation : MonoBehaviour
{
    public Vector3 rotationPos;
    public bool isUpDown = false;

    private void Start()
    {
        transform.DOLocalRotate(rotationPos, 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetRelative(true).SetEase(Ease.Linear);

        if (isUpDown)
        {
            UpDown();
        }
    }

    private void UpDown()
    {
        transform.DOMoveY(0.3f, 2f).SetLoops(-1, LoopType.Yoyo).SetRelative(true).SetEase(Ease.Linear);
    }
}
