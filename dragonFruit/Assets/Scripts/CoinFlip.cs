using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoinFlip : MonoBehaviour
{
    private int rValue;
    public string result;
    public HeadsOrTailsSelection selection;
    public int betableMoney;
    public PlayerBettingButtons res;
    public FlipButton flip;
    public bool isPressed;
    public int betOfPlayer;
    public int totalBetofWinners;
    public int totalPot;
    public int outCome;

    // Use this for initialization
    void Start ()
    {
        betOfPlayer = res.result;
        totalPot = res.result;
        totalBetofWinners = res.result;

        betableMoney = 10;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if(betableMoney <= 0)
        {
            SceneManager.LoadScene("SceneOne");
        }

    }

    public void CoinToss()
    {
        {
            rValue = Random.Range(1, 101);
            if (rValue <= 48)
            {
                result = "Heads";
                print(result);
            }

            if (rValue > 48 && rValue < 96)
            {
                result = "Tails";
                print(result);
            }

            if (rValue > 96)
            {
                result = "Edge";
                print(result);
            }

            CheckSelection();
        }

    }

    void CheckSelection()
    {
        if(selection.HeadsOrTails == "Heads" && result == "Heads")
        {
            print("You WIN!");
            betableMoney += res.result;
        }
        else if (selection.HeadsOrTails == "Tails" && result == "Tails")
        {
            print("You WIN!");
            betableMoney += res.result;
        }
        else if (selection.HeadsOrTails == "Edge" && result == "Edge")
        {
            print("You WIN!");
            betableMoney += res.result * 2;
        }
        else
        {
            print("You LOSE!");
            betableMoney -= res.result;
        }
    }
}
