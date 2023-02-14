using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class UniRx_Coroutine : MonoBehaviour
{
    void Start()
    {
        Observable.FromCoroutine<int>(observer => GameTimerCoroutine(observer, 60))
            .Subscribe(t => Debug.Log(t));
    }


    IEnumerator GameTimerCoroutine(IObserver<int> observer, int initialCount)
    {
        var count = initialCount;

        WaitForSeconds oneSecond = new WaitForSeconds(1.0f);

        while(count > 0)
        {
            observer.OnNext(--count);

            yield return oneSecond;
        }

        observer.OnNext(0);
        observer.OnCompleted();
    }

}
