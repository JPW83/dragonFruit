using UnityEngine;
using System.Collections;

public class PlayerBettingButtons : MonoBehaviour
{
    public int betAmount;
    public int result;
    public bool isPressed;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void One()
    {
        betAmount = 1;
        result = betAmount;
    }

    public void Two()
    {
        betAmount = 2;
        result = betAmount;
    }

    public void Three()
    {
        betAmount = 3;
        result = betAmount;
    }

    public void Four()
    {
        betAmount = 4;
        result = betAmount;
    }

    public void Five()
    {
        betAmount = 5;
        result = betAmount;
    }

}
