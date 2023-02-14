using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerClass_UniRx : MonoBehaviour
{

    //Stream »ý¼º
    public Subject<int> eventTimer = new Subject<int>();

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
