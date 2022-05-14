using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerCollision : MonoBehaviourPunCallbacks
{
    public static PlayerCollision instance;
    PhotonView PV;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject loseScreen;

    private void Awake()
    {
        instance = this;   
    }

    private void Start()
    {
        PV = GetComponent<PhotonView>();
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    [PunRPC]
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            if(PhotonNetwork.LocalPlayer.IsMasterClient)
            {
                winScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
}
