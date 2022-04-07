using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HammerScript : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int score;

    private MoleScript MoleScript;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        MoleScript = GetComponent<MoleScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MolePoint()
    {
        //PointsText.text = points + "/10";
    }
}
