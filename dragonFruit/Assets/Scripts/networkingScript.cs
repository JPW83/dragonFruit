using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class networkingScript : NetworkBehaviour {
    [SyncVar] private Vector3 syncPosition;
    private Transform playerTransform;
    public TextMesh playerName;
    /*public CoinFlip coinFlipScript;
    public int _winnings;
    public int _betOfPlayer;
    public int _totalBetofWinners;
    public int _totalPot;
    public int _betableMoney;*/


    void Start () {
        playerName = gameObject.GetComponentInChildren<TextMesh>();
        playerName.text = PlayerPrefs.GetString("UN");
        playerTransform = GetComponent<Transform>();
	}
	
    void FixedUpdate () {
        TransmitPosition();
    }

	void Update () {
	    
	}

    [Command] void CmdSendPositionToServer(Vector3 _position) {
        syncPosition = _position;
    }
    [ClientCallback] void TransmitPosition() {
        if (isLocalPlayer) {
            CmdSendPositionToServer(playerTransform.position);
        }
    }

    /*[Command] void CmdSendPlayerBet() {
        coinFlipScript.winnings = _winnings;
        coinFlipScript.betOfPlayer = _betOfPlayer;
        coinFlipScript.totalBetofWinners = _totalBetofWinners;
        coinFlipScript.totalPot = _totalPot;
        coinFlipScript.betableMoney = _betableMoney;
    }
    [ClientCallback] void TransmitPlayerBet() {
        if (isLocalPlayer) {
            _winnings = _betOfPlayer / _totalBetofWinners * _totalPot;
            _betableMoney += _winnings;
        }
    }*/
}
