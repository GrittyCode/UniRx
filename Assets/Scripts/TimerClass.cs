using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerClass : MonoBehaviour
{
    public delegate void TimerEventHandler(int time); //�̺�Ʈ �ڵ鷯    
    public event TimerEventHandler eventTimer;  //�̺�Ʈ �ڵ鷯 Delegate�� ���� �̺�Ʈ

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
            // 1�� �� �ٽ� time �߰�
            yield return new WaitForSeconds(1);
        }
    }
}
