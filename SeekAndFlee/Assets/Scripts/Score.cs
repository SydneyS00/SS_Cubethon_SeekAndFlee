using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
    //reference to player
    public Transform playerPos;
    public TextMeshProUGUI score; 

    private void Update()
    {
        score.text = playerPos.position.z.ToString("0");
    }
}
