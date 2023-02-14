using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ReactivePropertyStudy : MonoBehaviour
{
    private void Start()
    {
        var rp = new ReactiveProperty<int>();

        rp.Value = 5;
        rp.Value = 10;

        //Value가 수정되면 구독된 람다식이 실행된다.
        rp.Subscribe(x => Debug.Log(x));


        rp.Value = 12;
        rp.Value = 30;

    }
}
