using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;

public class NetworkingBetting : NetworkBehaviour {
    public CoinFlip coinFlipScript;
    public int _winnings;
    public int _betOfPlayer;
    public int _totalBetofWinners;
    public int _totalPot;
    public int _betableMoney;
    public List<GameObject> playersOnline;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    [Command]
    void CmdSendPlayerBet() {
        coinFlipScript.betOfPlayer = _betOfPlayer;
        coinFlipScript.totalBetofWinners = _totalBetofWinners;
        coinFlipScript.totalPot = _totalPot;
        coinFlipScript.betableMoney = _betableMoney;
    }
    [ClientCallback]
    void TransmitPlayerBet() {
        if (isLocalPlayer) {
            _winnings = _betOfPlayer / _totalBetofWinners * _totalPot;
            _betableMoney += _winnings;
        }
    }
    void OnClientConnect (NetworkConnection conn, int i) {
        if (conn.isConnected) {
            
        }
    }
}
