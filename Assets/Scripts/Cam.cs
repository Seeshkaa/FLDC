using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject target;
    public Transform[] points;
   
    public int index—urrent = 0;
    public bool f = false;
    private float speed = 1f;

   void Start()
    {
        Sequence a = DOTween.Sequence();
        a.Append(transform.DOMove(points[0].position, 0));
        a.Join(transform.DODynamicLookAt(target.transform.position, 0));
    }


    void Update()
    {
        transform.LookAt(target.transform);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (index—urrent < points.Length - 1)
                index—urrent = index—urrent + 1;
            else
                index—urrent = 0;         
            f = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (index—urrent > 0)
                index—urrent = index—urrent - 1;
            else
                index—urrent = points.Length - 1;

            f = true;
        }
        SlerpMove(f);
    }

    void SlerpMove(bool f)
    {
        if (f == true)
        {
            transform.position = Vector3.Lerp(transform.position, points[index—urrent].position, Time.deltaTime * speed);
            f = false;
        }
    }
}
