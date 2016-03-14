using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class connection : NetworkBehaviour {
    public NetworkingBetting NB;
	void Start () {
        if (isClient) {
            NB.playersOnline.Add(this.gameObject);
        }
	}
}
