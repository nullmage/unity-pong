using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

	public static int PlayerScore1 = 0;
	public static int PlayerScore2 = 0;

    public GameObject ll_Text;
    private TextMeshPro l_Text;
    public GameObject rr_Text;
    private TextMeshPro r_Text;
    GameObject theBall;

	// Use this for initialization
	void Start () {
		theBall = GameObject.FindGameObjectWithTag ("Ball");
        l_Text = ll_Text.GetComponent<TextMeshPro>();
        r_Text = rr_Text.GetComponent<TextMeshPro>();


        l_Text.text = "hello";// PlayerScore1.ToString();
        r_Text.text = PlayerScore2.ToString();
	}

    void Update()
    {
        l_Text.text = PlayerScore1.ToString();
        r_Text.text = PlayerScore2.ToString();
    }

    public static void Score(string wallID)
    {
        if (wallID == "RightWall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }

}
