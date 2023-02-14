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

        //Value�� �����Ǹ� ������ ���ٽ��� ����ȴ�.
        rp.Subscribe(x => Debug.Log(x));


        rp.Value = 12;
        rp.Value = 30;

    }
}
