using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


//delegate와 event를 사용한 코드
public class TimerView : MonoBehaviour
{
    [SerializeField] TimerClass timeCounter;
    void Start()
    {
        timeCounter.eventTimer += x =>
        {
            Debug.Log(x.ToString());
        };
    }
}



/*
public class TimerClass_UniRx : MonoBehaviour
{
    public Subject<int> eventTimer;

    private void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        int time = 1;
        WaitForSeconds oneSecond = new WaitForSeconds(1.0f);

        while (time < 100)
        {
            eventTimer.OnNext(time);
            ++time;

            yield return oneSecond;
        }
    }

}

//unirx를 이용한 코드
public class TimerView_UniRx : MonoBehaviour
{
    [SerializeField] private TimerClass_UniRx timeCounter;

    private void Start()
    {
        timeCounter.eventTimer.Subscribe(msg =>
        {
            Debug.Log(msg.ToString());
        });
    }
}
*/