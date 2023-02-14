using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers; //Update관련 구문을 담고 있는 네임스페이스다.

public class Observer_Trigger : MonoBehaviour
{
    private void Start()
    {
        this.UpdateAsObservable()
            .Subscribe(_ => Debug.Log("Update"));  
    }
}
