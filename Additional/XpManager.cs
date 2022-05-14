using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class XpManager : MonoBehaviour
{
    public static int sliderValue = 0;
    public Slider xpSlider;


    private void SliderValue(int _sliderValue)
    {
        sliderValue = _sliderValue;
        xpSlider.value += _sliderValue;
    }
}
