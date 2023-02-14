using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UniRx_UGUI.GetSlide.OnValueChangedAsObservable().Subscribe(value => Debug.Log("새로운 구독 추가 됨" + value.ToString()));
    }

}
