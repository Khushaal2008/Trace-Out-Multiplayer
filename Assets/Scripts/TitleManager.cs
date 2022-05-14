using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{

    [SerializeField] GameObject titleTrace;
    [SerializeField] GameObject titleOut;

    public void VanishTitle()
    {
        titleTrace.SetActive(false);
        titleOut.SetActive(false);
    }

    public void TitleShow()
    {
        titleTrace.SetActive(true);
        titleOut.SetActive(true);
    }
}
