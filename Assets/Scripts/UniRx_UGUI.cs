using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class UniRx_UGUI : MonoBehaviour
{

    [SerializeField] static Slider slider;
    public static Slider GetSlide { get { return slider; } }
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Start()
    {
        slider.OnValueChangedAsObservable().Subscribe(value => Debug.Log("Slider의 값은 : " + value + "입니다."));
    }

}
