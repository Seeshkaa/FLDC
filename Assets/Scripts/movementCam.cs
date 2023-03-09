using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCam : MonoBehaviour
{
    public Transform obj;
    public List<Transform> points;


    public void Star()
    {
        var tween = DOTween.Sequence();
        tween.Append(transform.DOMove(points[0].position, 0));
        tween.Join(transform.DODynamicLookAt(obj.position, 0));

        foreach (var i in points)
        {
            tween.Append(transform.DOMove(i.position, 3.75f).SetEase(Ease.InQuad));
            tween.Join(transform.DODynamicLookAt(obj.position, 3.75f).SetEase(Ease.InQuad));
           
        }

        tween.Append(transform.DOMove(points[0].position, 3.75f).SetEase(Ease.InQuad));
        tween.Join(transform.DODynamicLookAt(obj.position, 3.75f).SetEase(Ease.InQuad));
        
        
        //a.SetLoops(-1);
    }   
}

