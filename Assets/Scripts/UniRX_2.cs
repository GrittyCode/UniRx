using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class UniRX_2 : MonoBehaviour
{
    Subject<string> subject = new Subject<string>();
    

    void Start()
    {
        subject.Subscribe(msg => Debug.Log("Subscribe1" + msg));   
        subject.Subscribe(msg => Debug.Log("Subscribe2" + msg));   
        subject.Subscribe(msg => Debug.Log("Subscribe3" + msg));

        subject.OnNext("Hello");
        subject.OnNext("Hi");

    }

}
