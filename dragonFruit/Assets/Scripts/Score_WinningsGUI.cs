using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_WinningsGUI : MonoBehaviour
{
    public GameObject Moolah;
    public CoinFlip betableMoolah;
    public GameObject OutCome;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Moolah.GetComponent<Text>().text = "Bank: " + betableMoolah.betableMoney;

        OutCome.GetComponent<Text>().text = "The last flip was: " + betableMoolah.result;
    }

}
