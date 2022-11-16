using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dotmove : MonoBehaviour
{
    


    void Start()
    {
        Tweener move1;
        Tweener move2;

        Sequence seq = DOTween.Sequence();
        move1 = transform.DOMove(Vector3.one, 3f);
        move2 = transform.DOMove(Vector3.zero, 3f);

        seq.Append(move1);
        seq.Append(move2);
        
        //seq.Append(obj.transform.DOScale(Vector3.zero, 3f)).
        //    Prepend(obj.transform.DOMove(Vector3.one, 3f));

    }
}
