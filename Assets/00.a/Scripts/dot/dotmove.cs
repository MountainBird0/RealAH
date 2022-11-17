using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dotmove : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        Sequence seq = DOTween.Sequence();
        
        Tweener move1 = transform.DOMove(Vector3.one, 3f);
        Tweener move2 = transform.DOMove(Vector3.zero, 3f);

        //move1 = cube.transform.DOMove(Vector3.one, 3f);
        //move2 = cube.transform.DOMove(Vector3.zero, 3f);

        //seq.Append(move1).Append(move2);

        cube.transform.DOMoveX(200, 2f).SetRelative();
    }
}
