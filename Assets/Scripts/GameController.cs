using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Cell[] cells;
    [SerializeField] private BackgroundAnimator backgroundAnimator;
    [SerializeField] private Button button;
    
    private void Commence()
    {
        Cell cell = GetRandomCell();
        if (cell != null)
        {
            cell.SetRevealed();

            //TODO: animate Orb at the appropriate time

            cell.RevealCell(); //TODO: call this method at the appropriate time
        }
        else DisableButtonAndStartBackgroundAnimation();
    }

    private void DisableButtonAndStartBackgroundAnimation()
    {
        backgroundAnimator.AnimateBackground();
        DisableButton();
    }

    public void OnButtonClick()
    {
        //******
        //DO NOT edit this method
        //******
        Commence();
    }
    
    private Cell GetRandomCell()
    {
        //******
        //DO NOT edit this method
        //******
        int startX = Random.Range(0, cells.GetLength(0));

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            int indexX = (startX + i) % cells.GetLength(0);
            Cell temp = cells[indexX];

            if (temp == null) continue;
            if (!temp.IsRevealed()) return temp;
        }

        return null;
    }
    
    private void DisableButton()
    {
        //******
        //DO NOT edit this method
        //******
        button.interactable = false;
    }
}