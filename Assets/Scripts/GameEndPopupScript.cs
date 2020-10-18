using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEndPopupScript : MonoBehaviour
{


    public TextMeshProUGUI resultText;

    // Start is called before the first frame update
    void Start()
    {
        Utility.SetCanvasGroupEnabled(GetComponent<CanvasGroup>(), false);
    }

    // Update is called once per frame
    public void ShowWinPopup()
    {        
        Debug.Log("ShowWinPopup");
        Utility.SetCanvasGroupEnabled(GetComponent<CanvasGroup>(), true);
        resultText.text = "YOU WIN! =)";
    }

    public void ShowLosePopup()
    {        
        Debug.Log("ShowLosePopup");
        Utility.SetCanvasGroupEnabled(GetComponent<CanvasGroup>(), true);
        resultText.text = "YOU LOSE =(";
    }

    public void ShowEndGameOverlayOnExitPressed(){
        Debug.Log("ShowEndGameOverlayOnExitPressed");
        LoadingScreen.instance.LoadScene("MainMenu");
    }

}
