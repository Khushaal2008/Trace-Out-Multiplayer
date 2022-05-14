using System;
using System.Collections;


using UnityEngine;
using UnityEngine.SceneManagement;


using Photon.Pun;
using Photon.Realtime;

public class PlayerStatus : MonoBehaviourPunCallbacks
{

    public void OnClick_LeaveRoom()
    {
        PhotonNetwork.LeaveRoom(true);
        MenuManager.instance.OpenMenu("loading");
        PhotonNetwork.LoadLevel(0);
        PhotonNetwork.ConnectUsingSettings();
    }
    
}