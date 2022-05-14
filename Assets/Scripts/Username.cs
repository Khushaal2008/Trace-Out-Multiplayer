using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    [SerializeField] PhotonView playerPV;
    [SerializeField] Text usernameText;

    private void Start()
    {

        if(playerPV.IsMine)
        {
            gameObject.SetActive(false);
        }

        usernameText.text = playerPV.Owner.NickName;
    }
}
