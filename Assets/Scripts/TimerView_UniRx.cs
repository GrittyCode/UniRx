using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

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
