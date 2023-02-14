using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerClass : MonoBehaviour
{
    public delegate void TimerEventHandler(int time); //이벤트 핸들러    
    public event TimerEventHandler eventTimer;  //이벤트 핸들러 Delegate에 보낼 이벤트

    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }


    IEnumerator TimerCoroutine()
    {
        int time = 1;
        while (time <= 100)
        {
            eventTimer(time);
            time++;
            // 1초 후 다시 time 추가
            yield return new WaitForSeconds(1);
        }
    }
}
