using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers; //Update���� ������ ��� �ִ� ���ӽ����̽���.

public class Observer_Trigger : MonoBehaviour
{
    private void Start()
    {
        this.UpdateAsObservable()
            .Subscribe(_ => Debug.Log("Update"));  
    }
}
